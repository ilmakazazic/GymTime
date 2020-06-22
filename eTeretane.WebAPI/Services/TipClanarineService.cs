using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eTeretane.Model;
using eTeretane.WebAPI.EF;

namespace eTeretane.WebAPI.Services
{
    public class TipClanarineService : BaseService<TipClanarine, object, Database.TipClanarine>
    {
        public TipClanarineService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
