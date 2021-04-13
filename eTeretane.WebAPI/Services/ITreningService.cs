using System.Collections.Generic;

namespace eTeretane.WebAPI.Services
{
    public interface ITreningService 
    {
        List<Model.Trening> GetByDateGym(string date, int Teretanaid, int TrenerId);
    }
}
