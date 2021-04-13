using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Services;

namespace eTeretane.WebAPI.Controllers
{
    public class TeretanaController : BaseCRUDController<Model.Teretane, TeretanaSearchRequest, TeretanaUpsertRequest, TeretanaUpsertRequest>
    {
        public TeretanaController(ICRUDService<Teretane, TeretanaSearchRequest, TeretanaUpsertRequest, TeretanaUpsertRequest> service) : base(service)
        {
        }
    }
}