using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.EF;

namespace eTeretane.WebAPI.Services
{
    public class ClanarinaService : IClanarina
    {
        private readonly eTeretaneContext _context;
        private readonly IMapper _mapper;

        public ClanarinaService(eTeretaneContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Clanarina> Get()
        {
            return _mapper.Map<List<Model.Clanarina>>(_context.Clanarina.ToList());

        }

        public Clanarina GetById(int id)
        {
            return _mapper.Map<Model.Clanarina>(_context.Clanarina.Find(id));
        }

        public Clanarina Insert(ClanarinaUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Clanarina>(request);


            _context.Clanarina.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Clanarina>(entity);
        }

        public Clanarina Update(int id, ClanarinaUpsertRequest request)
        {
            var entity = _context.Clanarina.Find(id);

            _context.Clanarina.Attach(entity);
            _context.Clanarina.Update(entity);

            _context.SaveChanges();
            return _mapper.Map<Model.Clanarina>(entity);
        }
    }
}
