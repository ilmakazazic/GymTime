﻿using System.Collections.Generic;
using eTeretane.Model.Requests;

namespace eTeretane.WebAPI.Services
{
    public interface IPlacanjeClanarine
    {
        List<Model.PlacanjeClanarine> Get(PlacanjeClanarineSearchRequest request);
        Model.PlacanjeClanarine GetById(int id);
        Model.PlacanjeClanarine Insert(PlacanjeClanarineUpsertRequest request);
        Model.PlacanjeClanarine Update(int id, PlacanjeClanarineUpsertRequest request);
    }
}
