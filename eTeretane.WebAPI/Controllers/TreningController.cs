using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTeretane.WebAPI.Controllers
{

    [Route("api/[controller]")]

    [ApiController]
    public class TreningController : BaseCRUDController<Model.Trening, object, TreningUpsertRequest, TreningUpsertRequest>
    {
        private readonly ITreningService _treningService;

        public TreningController(ICRUDService<Trening, object, TreningUpsertRequest, TreningUpsertRequest> service, ITreningService treningService) : base(service)
        {
            _treningService = treningService;
        }

        [HttpGet("GetByDateGym/{date}/{TeretanaId}/{TrenerId}")]
        public List<Model.Trening> GetByDateGym(string date, int TeretanaId, int TrenerId)
        {
            return _treningService.GetByDateGym(date, TeretanaId, TrenerId);
        }

    }
}