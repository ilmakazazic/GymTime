using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Services;

namespace eTeretane.WebAPI.Controllers
{
    public class LicenceController : BaseCRUDController<Model.Licenca, object, LicencaUpsertRequest, LicencaUpsertRequest>
    {
        public LicenceController(ICRUDService<Licenca, object, LicencaUpsertRequest, LicencaUpsertRequest> service) : base(service)
        {
        }
    }
}
