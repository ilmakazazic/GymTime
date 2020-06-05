﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            if (search != null)
            {
               querry = querry.Where(c => c.TreningId == search.teretanaId);

            }

            var list = querry.ToList();

            return _mapper.Map<List<Model.TreningDetalji>>(list);
        }
    }
}
