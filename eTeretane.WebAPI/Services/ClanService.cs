using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.EF;

namespace eTeretane.WebAPI.Services
{
    public class ClanService : IClanService
    {
        private readonly eTeretaneContext _context;
        private readonly IMapper _mapper;

        public ClanService(eTeretaneContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Clanovi> Get(ClanSearchRequest request)
        {
            var querry = _context.Clan.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                querry = querry.Where(x => x.Ime.StartsWith(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                querry = querry.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            var list = querry.ToList();
            return _mapper.Map<List<Model.Clanovi>>(list);
        }

        public Clanovi GetById(int id)
        {
            var entity = _context.Clan.Find(id);
            return _mapper.Map<Model.Clanovi>(entity);
        }

        public Clanovi Insert(ClanUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Clan>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Lozinke se ne poklapaju");
            }

            //entity.LozinkaSalt = GenerateSalt();
            //entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            //entity.DatumRegistracije = DateTime.Now;
            //entity.Status = true;


            _context.Clan.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Clanovi>(entity);

        }

        public Clanovi Update(int id, ClanUpsertRequest request)
        {
            var entity = _context.Clan.Find(id);
            _context.Clan.Attach(entity);
            _context.Clan.Update(entity);


            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Lozinke se ne poklapaju");

                }
                // DODAT CEMO KOD ZA HASH
            }

            _mapper.Map(request, entity);
            var a = request;

            _context.SaveChanges();
            return _mapper.Map<Model.Clanovi>(entity);
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
