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

    public class TreningZahtjevController : BaseCRUDController<TreningZahtjev, object, TreningZahtjevUpsertRequest, TreningZahtjevUpsertRequest>
    {
        public TreningZahtjevController(ICRUDService<TreningZahtjev, object, TreningZahtjevUpsertRequest, TreningZahtjevUpsertRequest> service) : base(service)
        {
        }
    }
}