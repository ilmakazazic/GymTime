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
    public class TreningDodatniService : BaseCRUDService<TreningDodatni, TreningDodatniSearchRequest, Database.TreningDodatni, TreningDodatniUpsertRequest, TreningDodatniUpsertRequest>
    {
        public TreningDodatniService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<TreningDodatni> Get(TreningDodatniSearchRequest search)
        {
            var querry = _context.Set<Database.TreningDodatni>()
                .Include(x => x.Teretana)
                .Include(x => x.Clan)
                .Include(x => x.Korisnik).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                querry = querry.Where(x => x.Clan.Ime.StartsWith(search.Naziv) ||
                                           x.Clan.Prezime.StartsWith(search.Naziv) ||
                                           x.Korisnik.Ime.StartsWith(search.Naziv) ||
                                           x.Korisnik.Prezime.StartsWith(search.Naziv) ||
                                           x.Teretana.Naziv.StartsWith(search.Naziv) &&
                                           x.Prihvacen==search.Prihvacen);
            }
            else
            {
                querry = querry.Where(x=>x.Prihvacen == search.Prihvacen);

            }

            var list = querry.ToList();
            return _mapper.Map<List<TreningDodatni>>(list);

        }
    }
}
