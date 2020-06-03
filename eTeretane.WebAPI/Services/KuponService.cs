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
    public class KuponService : BaseCRUDService<Model.KuponPopusti, KuponSearchRequest, KuponPopust, KuponUpsertRequest, KuponUpsertRequest>
    {
        public KuponService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.KuponPopusti> Get(KuponSearchRequest search)
        {
            var querry = _context.Set<KuponPopust>().AsQueryable();

            if (search.TeretanaId > 0)
            {
                querry = querry.Where(x => x.TeretanaId==search.TeretanaId);
            }
            querry = querry.OrderBy(c => c.PocetakDatum);
            var list = querry.ToList();
            return _mapper.Map<List<Model.KuponPopusti>>(list);
        }
    }
}
