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

    public class GradoviController : BaseCRUDController<Model.Grad, object, GradUpsetRequest, GradUpsetRequest>
    {
        public GradoviController(ICRUDService<Grad, object, GradUpsetRequest, GradUpsetRequest> service) : base(service)
        {
        }
    }
}
