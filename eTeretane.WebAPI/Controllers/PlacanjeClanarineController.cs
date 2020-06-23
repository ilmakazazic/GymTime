using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTeretane.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PlacanjeClanarineController : ControllerBase
    {
        private readonly IPlacanjeClanarine _service;

        public PlacanjeClanarineController(IPlacanjeClanarine service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.PlacanjeClanarine>> Get([FromQuery] PlacanjeClanarineSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.PlacanjeClanarine GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.PlacanjeClanarine Insert(PlacanjeClanarineUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.PlacanjeClanarine Update(int id, PlacanjeClanarineUpsertRequest request)
        {
            return _service.Update(id, request);
        }

    }
}
