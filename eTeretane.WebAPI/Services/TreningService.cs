using AutoMapper;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Database;
using eTeretane.WebAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Services
{
    public class TreningService : BaseCRUDService<Model.Trening, object, Database.Trening, TreningUpsertRequest, TreningUpsertRequest>, ITreningService
    {
        public TreningService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public List<Model.Trening> GetByDateGym(string date, int Teretanaid, int TrenerId)
        {
            var querry = _context.Set<Trening>().AsQueryable();
            if (TrenerId > 0)
            {
                querry = querry.Where(x => x.DatumOdrzavanja.ToString() == date && x.TeretanaId == Teretanaid && x.KorisnikId == TrenerId);

            }
            else
            {
                querry = querry.Where(x => x.DatumOdrzavanja.ToString() == date && x.TeretanaId == Teretanaid);

            }
                                                                   

            //var querry = _context.Set<Trening>().Where(x =>  x.TeretanaId == Teretanaid && x.KorisnikId == TrenerId).AsQueryable();

            var list = querry.ToList();

            return _mapper.Map<List<Model.Trening>>(list);
        }



    }
}