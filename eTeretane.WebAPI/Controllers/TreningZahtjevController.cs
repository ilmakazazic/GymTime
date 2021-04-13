using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Services;

namespace eTeretane.WebAPI.Controllers
{
    public class TreningZahtjevController : BaseCRUDController<TreningZahtjev, TreningZahtjevSearchRequest, TreningZahtjevUpsertRequest, TreningZahtjevUpsertRequest>
    {
        public TreningZahtjevController(ICRUDService<TreningZahtjev, TreningZahtjevSearchRequest, TreningZahtjevUpsertRequest, TreningZahtjevUpsertRequest> service) : base(service)
        {
        }
    }
}