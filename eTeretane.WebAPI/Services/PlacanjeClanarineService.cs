using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.EF;
using Microsoft.EntityFrameworkCore;

namespace eTeretane.WebAPI.Services
{
    public class PlacanjeClanarineService : IPlacanjeClanarine
    {
        private readonly eTeretaneContext _context;
        private readonly IMapper _mapper;
        private readonly IClanarina _clanarinaService;


        public PlacanjeClanarineService(eTeretaneContext context, IMapper mapper, IClanarina clanarina)
        {
            _context = context;
            _mapper = mapper;
            _clanarinaService = clanarina;
        }
        public List<PlacanjeClanarine> Get(PlacanjeClanarineSearchRequest request)
        {
            var querry = _context.PlacanjeClanarine.AsQueryable();

            var list = querry.Include(c => c.Clanarina).ToList();
            return _mapper.Map<List<Model.PlacanjeClanarine>>(list);
        }


        public PlacanjeClanarine GetById(int id)
        {
            var entity = _context.PlacanjeClanarine.Include(c => c.Clanarina).Single(v => v.PlacanjeClanarineID == id);
            return _mapper.Map<Model.PlacanjeClanarine>(entity);
        }

        public PlacanjeClanarine Insert(PlacanjeClanarineUpsertRequest request)
        {
            var entity = _mapper.Map<Database.PlacanjeClanarine>(request);
            var clanarinaId = _clanarinaService.Insert(request).ClanarinaId;

            entity.ClanarinaId = clanarinaId;
            

            _context.PlacanjeClanarine.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.PlacanjeClanarine>(entity);

        }

        public PlacanjeClanarine Update(int id, PlacanjeClanarineUpsertRequest request)
        {
            var entity = _context.PlacanjeClanarine.Find(id);
            _context.PlacanjeClanarine.Attach(entity);
            _context.PlacanjeClanarine.Update(entity);


            _mapper.Map(request, entity);

            _clanarinaService.Update(entity.ClanarinaId, request);

            _context.SaveChanges();
            return _mapper.Map<Model.PlacanjeClanarine>(entity);
        }


    }
}
