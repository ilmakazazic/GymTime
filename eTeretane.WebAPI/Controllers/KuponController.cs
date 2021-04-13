using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Services;

namespace eTeretane.WebAPI.Controllers
{
    public class KuponController : BaseCRUDController<Model.KuponPopusti, KuponSearchRequest, KuponUpsertRequest, KuponUpsertRequest>
    {
        public KuponController(ICRUDService<KuponPopusti, KuponSearchRequest, KuponUpsertRequest, KuponUpsertRequest> service) : base(service)
        {
        }
    }
}