using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTeretane.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreningDetaljiController : BaseCRUDController<TreningDetalji, TreningDetaljiSearchRequest, TreningDetaljiUpsertRequest, TreningDetaljiUpsertRequest>
    {
        public TreningDetaljiController(ICRUDService<TreningDetalji, TreningDetaljiSearchRequest, TreningDetaljiUpsertRequest, TreningDetaljiUpsertRequest> service) : base(service)
        {
        }
    }
}