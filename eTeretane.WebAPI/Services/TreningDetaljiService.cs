using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.EF;

namespace eTeretane.WebAPI.Services
{
    public class TreningDetaljiService : BaseCRUDService<TreningDetalji, TreningDetaljiSearchRequest, Database.TreningDetalji, TreningDetaljiUpsertRequest, TreningDetaljiUpsertRequest>
    {
        public TreningDetaljiService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<TreningDetalji> Get(TreningDetaljiSearchRequest search)
        {
            var querry = _context.Set<Database.TreningDetalji>().AsQueryable();

            if (search != null && search.treningId!=0)
            {
               querry = querry.Where(c => c.TreningId == search.treningId);

            }

            if (search != null && search.clanId != 0)
            {
                querry = querry.Where(c => c.ClanId == search.clanId);

            }

            var list = querry.ToList();
            return _mapper.Map<List<Model.TreningDetalji>>(list);
        }
    }
}
