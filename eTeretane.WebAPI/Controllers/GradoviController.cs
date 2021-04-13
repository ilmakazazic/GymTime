using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Services;
namespace eTeretane.WebAPI.Controllers
{
    public class GradoviController : BaseCRUDController<Model.Grad, object, GradUpsetRequest, GradUpsetRequest>
    {
        public GradoviController(ICRUDService<Grad, object, GradUpsetRequest, GradUpsetRequest> service) : base(service)
        {
        }
    }
}
