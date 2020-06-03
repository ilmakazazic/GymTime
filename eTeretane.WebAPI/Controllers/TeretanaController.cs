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

    public class TeretanaController : BaseCRUDController<Model.Teretane, TeretanaSearchRequest, TeretanaUpsertRequest, TeretanaUpsertRequest>
    {
        public TeretanaController(ICRUDService<Teretane, TeretanaSearchRequest, TeretanaUpsertRequest, TeretanaUpsertRequest> service) : base(service)
        {
        }
    }
}