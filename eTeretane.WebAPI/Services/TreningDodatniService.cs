using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.EF;

namespace eTeretane.WebAPI.Services
{
    public class TreningDodatniService : BaseCRUDService<TreningDodatni, object, Database.TreningDodatni, TreningDodatniUpsertRequest, TreningDodatniUpsertRequest>
    {
        public TreningDodatniService(eTeretaneContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
