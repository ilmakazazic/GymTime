using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Database;
using eTeretane.WebAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eTeretane.WebAPI.Services
{
    public class TeretanaService : BaseCRUDService<Model.Teretane, TeretanaSearchRequest, Database.Teretana, TeretanaUpsertRequest, TeretanaUpsertRequest>
    {
        public TeretanaService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Teretane> Get(TeretanaSearchRequest search)
        {
            var querry = _context.Set<Teretana>().Include(k=>k.Grad).AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                querry = querry.Where(x => x.Naziv.StartsWith(search.Naziv));
            }

            if (search!=null && search.GradId != 0)
            {
                //sortiranje na osnovu grada clanova
                querry = querry.OrderByDescending(m => m.GradId == search.GradId ? 0 : 1);
            }


            var list = querry.ToList();
            return _mapper.Map<List<Model.Teretane>>(list);
        }
    }
}
