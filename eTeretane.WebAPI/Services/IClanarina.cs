using System.Collections.Generic;
using eTeretane.Model.Requests;

namespace eTeretane.WebAPI.Services
{
    public interface IClanarina
    {
        List<Model.Clanarina> Get();
        Model.Clanarina GetById(int id);
        Model.Clanarina Insert(ClanarinaUpsertRequest request);
        Model.Clanarina Update(int id, ClanarinaUpsertRequest request);
    }
}
