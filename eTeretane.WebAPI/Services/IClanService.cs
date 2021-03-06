﻿using System.Collections.Generic;
using eTeretane.Model.Requests;

namespace eTeretane.WebAPI.Services
{
    public interface IClanService
    {
        List<Model.Clanovi> Get(ClanSearchRequest request);
        Model.Clanovi GetById(int id);
        Model.Clanovi Insert(ClanUpsertRequest request);
        Model.Clanovi Update(int id, ClanUpsertRequest request);
    }
}
