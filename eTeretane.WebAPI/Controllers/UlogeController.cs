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
    public class UlogeController : BaseController<Model.Uloge, object>
    {
        public UlogeController(IService<Uloge, object> service) : base(service)
        {
        }
    }
}