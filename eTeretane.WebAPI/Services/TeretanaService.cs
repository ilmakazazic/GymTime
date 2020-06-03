﻿using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Database;
using eTeretane.WebAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Services
{
    public class TeretanaService : BaseCRUDService<Model.Teretane, TeretanaSearchRequest, Database.Teretana, TeretanaUpsertRequest, TeretanaUpsertRequest>
    {
        public TeretanaService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Teretane> Get(TeretanaSearchRequest search)
        {
            var querry = _context.Set<Teretana>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                querry = querry.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            querry = querry.OrderBy(c => c.Naziv);
            var list = querry.ToList();
            return _mapper.Map<List<Model.Teretane>>(list);
        }
    }
}
