using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly eTeretaneContext _context;
        private readonly IMapper _mapper;
        private readonly IKorisnickiNalogService _korisnickiNalogService;

        public KorisniciService(eTeretaneContext context, IMapper mapper, IKorisnickiNalogService nalog)
        {
            _context = context;
            _mapper = mapper;
            _korisnickiNalogService = nalog;
        }

        public List<Korisnici> Get(KorisniciSearchRequest request)
        {
            var querry = _context.Korisnik.Include(k=>k.KorisnickiNalog).AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                querry = querry.Where(x => x.Ime.StartsWith(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                querry = querry.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Username))
            {
                querry = querry.Where(x => x.KorisnickiNalog.Username.StartsWith(request.Prezime));
            }

            var list = querry.ToList();
            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Korisnici GetById(int id)
        {
            var entity = _context.Korisnik.Include(c=>c.KorisnickiNalog).Single(i=>i.KorisnikId==id);
            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Korisnici Insert(KorisniciUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);

            var nalogId = _korisnickiNalogService.Insert(request).KorisnickiNalogId;

            entity.KorisnickiNalogId = nalogId;

            _context.Korisnik.Add(entity);
            _context.SaveChanges();
            

            foreach (var licenca in request.Licence)
            {
                _context.TrenerLicence.Add(new Database.TrenerLicence()
                {
                    KorisnikId = entity.KorisnikId,
                    LicencaId = licenca
                });
            }
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);

        }

        public Korisnici Update(int id, KorisniciUpsertRequest request)
        {

            var entity = _context.Korisnik.Find(id);
            _context.Korisnik.Attach(entity);
            _context.Korisnik.Update(entity);

            _mapper.Map(request, entity);

            _korisnickiNalogService.Update(entity.KorisnickiNalogId, request);

            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(entity);
        }

   
    }
}

