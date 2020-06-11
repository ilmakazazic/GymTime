using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.EF;
using Microsoft.EntityFrameworkCore;

namespace eTeretane.WebAPI.Services
{
    public class TreningZahtjevService : BaseCRUDService<Model.TreningZahtjev, TreningZahtjevSearchRequest, Database.TreningZahtjev, TreningZahtjevUpsertRequest, TreningZahtjevUpsertRequest>
    {

        public TreningZahtjevService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<TreningZahtjev> Get(TreningZahtjevSearchRequest search)
        {
            var querry = _context.Set<Database.TreningZahtjev>()
                .Include(x => x.Trening)
                .Include(x => x.Clan)
                .Include(x=>x.Trening.Teretana).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                querry = querry.Where(x => x.Clan.Ime.StartsWith(search.Naziv) ||
                                           x.Clan.Prezime.StartsWith(search.Naziv) ||
                                           x.Trening.Teretana.Naziv.StartsWith(search.Naziv) &&
                                           x.Odobren==search.odobren);
            }
            else
            {
                querry = querry.Where(x => x.Odobren == search.odobren);

            }

            var list = querry.ToList();
            return _mapper.Map<List<TreningZahtjev>>(list);

        }

    }
}
