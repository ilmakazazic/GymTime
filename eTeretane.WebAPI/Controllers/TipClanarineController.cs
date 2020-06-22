using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTeretane.Model;
using eTeretane.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTeretane.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipClanarineController : BaseController<TipClanarine, object>
    {
        public TipClanarineController(IService<TipClanarine, object> service) : base(service)
        {
        }
    }
}
