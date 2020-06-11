using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTeretane.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreningDodatniController : BaseCRUDController<TreningDodatni, TreningDodatniSearchRequest, TreningDodatniUpsertRequest, TreningDodatniUpsertRequest>
    {
        public TreningDodatniController(ICRUDService<TreningDodatni, TreningDodatniSearchRequest, TreningDodatniUpsertRequest, TreningDodatniUpsertRequest> service) : base(service)
        {
        }
    }
}