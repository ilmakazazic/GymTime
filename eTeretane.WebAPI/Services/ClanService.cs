using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eTeretane.Model;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.EF;
using Microsoft.EntityFrameworkCore;

namespace eTeretane.WebAPI.Services
{
    public class ClanService : IClanService
    {
        private readonly eTeretaneContext _context;
        private readonly IMapper _mapper;
        private readonly IKorisnickiNalogService _korisnickiNalogService;

        public ClanService(eTeretaneContext context, IMapper mapper, IKorisnickiNalogService nalog)
        {
            _context = context;
            _mapper = mapper;
            _korisnickiNalogService = nalog;
        }

        public List<Clanovi> Get(ClanSearchRequest request)
        {
            var querry = _context.Clan.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                querry = querry.Where(x => x.Ime.StartsWith(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                querry = querry.Where(x => x.Prezime.StartsWith(request.Prezime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Username))
            {
                querry = querry.Where(x => x.KorisnickiNalog.Username.StartsWith(request.Prezime));
            }

            var list = querry.Include(c=>c.KorisnickiNalog).ToList();
            return _mapper.Map<List<Model.Clanovi>>(list);
        }

        public Clanovi GetById(int id)
        {
            var entity = _context.Clan.Include(c => c.KorisnickiNalog).Single(v=>v.ClanId==id);
            return _mapper.Map<Model.Clanovi>(entity);
        }

        public Clanovi Insert(ClanUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Clan>(request);
            var nalogId = _korisnickiNalogService.Insert(request).KorisnickiNalogId;

            entity.KorisnickiNalogId = nalogId;
            entity.GradId = request.GradId;
            entity.DatumRegistracije = DateTime.Now;
            _context.Clan.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Clanovi>(entity);

        }

        public Clanovi Update(int id, ClanUpsertRequest request)
        {
            var entity = _context.Clan.Find(id);
            _context.Clan.Attach(entity);
            _context.Clan.Update(entity);


            _mapper.Map(request, entity);

            _korisnickiNalogService.Update(entity.KorisnickiNalogId, request);

            _context.SaveChanges();
            return _mapper.Map<Model.Clanovi>(entity);
        }
    }
}
