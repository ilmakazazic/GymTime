using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Services
{
    public interface ITreningService 
    {
        List<Model.Trening> GetByDateGym(string date, int Teretanaid, int TrenerId);
    }
}
