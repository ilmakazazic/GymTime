using AutoMapper;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Database;
using eTeretane.WebAPI.EF;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace eTeretane.WebAPI.Services
{
    public class TreningService : BaseCRUDService<Model.Trening, object, Database.Trening, TreningUpsertRequest, TreningUpsertRequest>, ITreningService
    {
        public TreningService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Trening> Get(object search)
        {
            var list = _context.Set<Trening>().Include(v=>v.Korisnik).Include(v => v.Teretana).ToList();
            return _mapper.Map<List<Model.Trening>>(list);
        }

        public override Model.Trening GetById(int id)
        {
            var entity = _context.Set<Trening>().Include(v => v.Korisnik)
                .Include(v => v.Teretana).Single(b=>b.TreningId==id);

            return _mapper.Map<Model.Trening>(entity);
        }

        public List<Model.Trening> GetByDateGym(string date, int Teretanaid, int TrenerId)
        {
            var querry = _context.Set<Trening>().Include(v => v.Korisnik).Include(v => v.Teretana).AsQueryable();
            if (TrenerId > 0)
            {
                querry = querry.Where(x => x.DatumOdrzavanja.ToString() == date && x.TeretanaId == Teretanaid && x.KorisnikId == TrenerId);

            }
            else
            {
                querry = querry.Where(x => x.DatumOdrzavanja.ToString() == date && x.TeretanaId == Teretanaid);

            }
            var list = querry.OrderBy(c=>c.PocetakTreninga.TimeOfDay).ToList();
            return _mapper.Map<List<Model.Trening>>(list);
        }
    }
}