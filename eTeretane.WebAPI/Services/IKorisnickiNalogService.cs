using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTeretane.Model.Requests;

namespace eTeretane.WebAPI.Services
{
    public interface IKorisnickiNalogService
    {
        List<Model.KorisnickiNalog> Get();
        Model.KorisnickiNalog GetById(int id);
        Model.KorisnickiNalog Insert(KorisnickiNalogUpsertRequest request);
        Model.KorisnickiNalog Update(int id, KorisnickiNalogUpsertRequest request);
        Model.KorisnickiNalog Authenticate(string username, string password);
    }
}

