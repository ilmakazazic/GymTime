using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTeretane.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTeretane.WebAPI.Controllers
{
    public class BaseCRUDController<T, TSearch, TUpdate, TInsert> : BaseController<T, TSearch>
    {
        public readonly ICRUDService<T, TSearch, TUpdate, TInsert> _service = null;
        public BaseCRUDController(ICRUDService<T, TSearch, TUpdate, TInsert> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public T Insert(TInsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public T Update(int id, TUpdate request)
        {
            return _service.Update(id, request);
        }
    }
}