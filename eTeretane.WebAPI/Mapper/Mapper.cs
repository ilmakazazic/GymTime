using AutoMapper;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Drzava, Model.Drzave>().ReverseMap();

            CreateMap<Grad, Model.Grad>().ReverseMap();          
            CreateMap<GradUpsetRequest, Grad>().ReverseMap();

            CreateMap<Teretana, Model.Teretane>().ReverseMap();
            CreateMap<TeretanaUpsertRequest, Teretana>();

            CreateMap<Korisnik, Model.Korisnici>(); // means you want to map from User to UserDTO
            CreateMap<Korisnik, KorisniciUpsertRequest>().ReverseMap();

            CreateMap<KorisnickiNalog, Model.KorisnickiNalog>().ReverseMap(); ; // means you want to map from User to UserDTO
            CreateMap<KorisnickiNalog, KorisnickiNalogUpsertRequest>().ReverseMap();


            CreateMap<Uloga, Model.Uloge>().ReverseMap();

            CreateMap<Trening, Model.Trening>().ReverseMap();
            CreateMap<TreningUpsertRequest, Trening>();

            CreateMap<Licenca, Model.Licence>().ReverseMap(); 
            CreateMap<Licenca, LicencaUpsertRequest>().ReverseMap();

            CreateMap<KuponPopust, Model.KuponPopusti>().ReverseMap();
            CreateMap<KuponUpsertRequest, KuponPopust>();

            CreateMap<Clan, Model.Clanovi>(); // means you want to map from User to UserDTO
            CreateMap<Clan, ClanUpsertRequest>().ReverseMap();

            CreateMap<TreningDetalji, Model.TreningDetalji>().ReverseMap();
            CreateMap<TreningDetaljiUpsertRequest, TreningDetalji>().ReverseMap();

            CreateMap<TreningZahtjev, Model.TreningZahtjev>().ReverseMap();
            CreateMap<TreningZahtjevUpsertRequest, TreningZahtjev>().ReverseMap();


            CreateMap<TreningDodatni, Model.TreningDodatni>().ReverseMap();
            CreateMap<TreningDodatniUpsertRequest, TreningDodatni>().ReverseMap();


        }

    }
}
