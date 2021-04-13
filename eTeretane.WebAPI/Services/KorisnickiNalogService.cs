using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.EF;
using eTeretane.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace eTeretane.WebAPI.Services
{
    public class KorisnickiNalogService : IKorisnickiNalogService
    {
        private readonly eTeretaneContext _context;
        private readonly IMapper _mapper;
        
        public KorisnickiNalogService(eTeretaneContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<KorisnickiNalog> Get()
        {
            return _mapper.Map<List<Model.KorisnickiNalog>>(_context.KorisnickiNalog.ToList());

        }

        public KorisnickiNalog GetById(int id)
        {
            return _mapper.Map<Model.KorisnickiNalog>(_context.KorisnickiNalog.Find(id));
        }

        public KorisnickiNalog Insert(KorisnickiNalogUpsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Lozinke se ne poklapaju!");
            }
            foreach (var nalog in _context.KorisnickiNalog.ToList())
            {
                if (nalog.Username == request.Username)
                    throw new UserException("Username se vec koristi!");
            }
            var entity = _mapper.Map<Database.KorisnickiNalog>(request);

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.KorisnickiNalog.Add(entity);
            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                _context.KorisniciUloge.Add(new Database.KorisniciUloge()
                {
                    DatumIzmjene = DateTime.Now,
                    UlogaId = uloga,
                    KorisnickiNalogId = entity.KorisnickiNalogId
                     
                });
            }

            _context.SaveChanges();
            return _mapper.Map<Model.KorisnickiNalog>(entity);
        }

        public KorisnickiNalog Update(int id, KorisnickiNalogUpsertRequest request)
        {
            var entity = _context.KorisnickiNalog.Find(id);

            _context.KorisnickiNalog.Attach(entity);
            _context.KorisnickiNalog.Update(entity);

            foreach (var nalog in _context.KorisnickiNalog.ToList())
            {
                if (nalog.Username == request.Username && nalog.Username != nalog.Username)
                    throw new UserException("Username je zauzet!");
            }

            if (request.Password != null)
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Passwords are not matching");
                }
                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            entity.Username = request.Username;
            var entityUloge = _context.KorisniciUloge.Where(c => c.KorisnickiNalogId == entity.KorisnickiNalogId).ToList();

            foreach (var postojuceUloge in entityUloge)
            {
                _context.KorisniciUloge.Remove(postojuceUloge);
            }
            
            _context.SaveChanges();

            foreach (var novaUloga in request.Uloge)
            {
                Database.KorisniciUloge korisniciUloge = new Database.KorisniciUloge();

                korisniciUloge.KorisnickiNalogId = entity.KorisnickiNalogId;
                korisniciUloge.UlogaId = novaUloga;
                korisniciUloge.DatumIzmjene = DateTime.Now;

                _context.KorisniciUloge.Add(korisniciUloge);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.KorisnickiNalog>(entity);
        }

        public KorisnickiNalog Authenticate(string username, string password)
        {
            var user = _context.KorisnickiNalog.Include("KorisniciUloge.Uloga").FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, password); //Pretvaramo u hash zbog poredjenja

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<Model.KorisnickiNalog>(user);

                }
            }

            return null;
        }

        private static string GenerateHash(string Salt, string password)
        {
            byte[] src = Convert.FromBase64String(Salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }

        private static string GenerateSalt()
        {
            var buf = new byte[16]; //deklaracija buffera
            (new RNGCryptoServiceProvider()).GetBytes(buf); //random broj
            return Convert.ToBase64String(buf); //konvertujemo ponovu u bazni tip da izbjegnemo error
        }

    }

}


