using System.Collections.Generic;
using System.Linq;
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

        public List<PlacanjeClanarine> Get(PlacanjeClanarineSearchRequest search)
        {
            var querry = _context.PlacanjeClanarine.Include(x=>x.Clanarina)
                .Include(x=>x.Clanarina.Clan)
                .Include(x => x.Clanarina.Teretana)
                .Include(x => x.Clanarina.TipClanarine).AsQueryable();

            if (search!=null && search.TeretanaId > 0 )
            {
                querry = querry.Where(x => x.Clanarina.TeretanaId == search.TeretanaId);

            }

            querry = querry.OrderBy(c => c.Clanarina.DatumIsteka);
            var list = querry.ToList();
            return _mapper.Map<List<Model.PlacanjeClanarine>>(list);
        }


        public PlacanjeClanarine GetById(int id)
        {
            var entity = _context.PlacanjeClanarine.Include(x => x.Clanarina)
                .Include(x => x.Clanarina.Clan)
                .Include(x => x.Clanarina.Teretana)
                .Include(x => x.Clanarina.TipClanarine).Single(v => v.PlacanjeClanarineID == id);
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
