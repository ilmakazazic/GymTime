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
    public class ClanController : ControllerBase
    {
        private readonly IClanService _service;

        public ClanController(IClanService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Clanovi>> Get([FromQuery]ClanSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Clanovi GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Clanovi Insert(ClanUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Clanovi Update(int id, ClanUpsertRequest request)
        {
            return _service.Update(id, request);
        }

    }
}