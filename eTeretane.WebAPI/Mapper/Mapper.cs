using AutoMapper;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace eTeretane.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Drzava, Model.Drzave>().ReverseMap();

            CreateMap<Grad, Model.Grad>().ReverseMap();          
            CreateMap<GradUpsetRequest, Grad>().ReverseMap();

            CreateMap<Teretana, Model.Teretane>()
                .ForMember(x=>x.Grad, v=>v.MapFrom(l=>l.Grad.Naziv)).ReverseMap();
            CreateMap<TeretanaUpsertRequest, Teretana>();

            CreateMap<Korisnik, Model.Korisnici>()
                .ForMember(x=>x.KorisnickoIme, b=>b.MapFrom(l=>l.KorisnickiNalog.Username)); // means you want to map from User to UserDTO
            CreateMap<Korisnik, KorisniciUpsertRequest>().ReverseMap();

            CreateMap<KorisnickiNalog, Model.KorisnickiNalog>().ReverseMap(); ; // means you want to map from User to UserDTO
            CreateMap<KorisnickiNalog, KorisnickiNalogUpsertRequest>().ReverseMap();


            CreateMap<Uloga, Model.Uloge>().ReverseMap();

            CreateMap<Trening, Model.Trening>()
                .ForMember(x => x.Korisnik, b => b.MapFrom(l => l.Korisnik)) // means you want to map from User to UserDTO
                .ForMember(x => x.TrenerString, b => b.MapFrom(l => l.Korisnik.Ime + " " + l.Korisnik.Prezime))
                .ForMember(x => x.TeretanaString, b => b.MapFrom(l => l.Teretana.Naziv)) // means you want to map from User to UserDTO
                .ReverseMap();
            CreateMap<TreningUpsertRequest, Trening>();

            CreateMap<Licenca, Model.Licenca>().ReverseMap(); 
            CreateMap<Licenca, LicencaUpsertRequest>().ReverseMap();

            CreateMap<KuponPopust, Model.KuponPopusti>()
                .ForMember(x => x.TeretanaString, b => b.MapFrom(l => l.Teretana.Naziv)) // means you want to map from User to UserDTO
                .ReverseMap();
            CreateMap<KuponUpsertRequest, KuponPopust>();

            CreateMap<Clan, Model.Clanovi>()
                .ForMember(x => x.KorisnickoIme, b => b.MapFrom(l => l.KorisnickiNalog.Username))
                .ForMember(x => x.KorisnickiNalog, b => b.MapFrom(l => l.KorisnickiNalog));

            CreateMap<Clan, ClanUpsertRequest>().ReverseMap();

            CreateMap<TreningDetalji, Model.TreningDetalji>().ReverseMap();
            CreateMap<TreningDetaljiUpsertRequest, TreningDetalji>().ReverseMap();

            CreateMap<TreningZahtjev, Model.TreningZahtjev>()
                .ForMember(x => x.ClanId, b => b.MapFrom(l => l.ClanId))
                .ForMember(x => x.ClanIme, b => b.MapFrom(l => l.Clan.Ime + " " + l.Clan.Prezime))
                .ForMember(x => x.TreningId, b => b.MapFrom(l => l.TreningId))
                .ForMember(x => x.TreningDatum, b => b.MapFrom(l => l.Trening.DatumOdrzavanja))
                .ForMember(x => x.TreningPocetak, b => b.MapFrom(l => l.Trening.PocetakTreninga))
                .ForMember(x => x.TreningKraj, b => b.MapFrom(l => l.Trening.KrajTreninga))
                .ForMember(x => x.TrenutnoRezervacija, b => b.MapFrom(l => l.Trening.BrojRezervacija))
                .ForMember(x => x.TeretanaId, b => b.MapFrom(l => l.Trening.TeretanaId))
                .ForMember(x => x.TeretanaIme, b => b.MapFrom(l => l.Trening.Teretana.Naziv));
            CreateMap<TreningZahtjevUpsertRequest, TreningZahtjev>().ReverseMap();


            CreateMap<TreningDodatni, Model.TreningDodatni>()
                .ForMember(x => x.ClanIme, b => b.MapFrom(l => l.Clan.Ime + " " + l.Clan.Prezime))
                .ForMember(x => x.TeretanaNaziv, b => b.MapFrom(l => l.Teretana.Naziv))
                .ForMember(x => x.KorisnikIme, b => b.MapFrom(l => l.Korisnik.Ime + " " + l.Korisnik.Prezime))
                .ReverseMap();
            CreateMap<TreningDodatniUpsertRequest, TreningDodatni>().ReverseMap();


            CreateMap<PlacanjeClanarine, Model.PlacanjeClanarine>()
                .ForMember(x => x.ClanString, v => v.MapFrom(l => l.Clanarina.Clan.Ime + " " + l.Clanarina.Clan.Prezime))
                .ForMember(x => x.TeretanaString, b => b.MapFrom(l => l.Clanarina.Teretana.Naziv))
                .ForMember(x => x.TipClanarineString, b => b.MapFrom(l => l.Clanarina.TipClanarine.Tip))
                .ForMember(x => x.cijenaString, b => b.MapFrom(l => l.Clanarina.TipClanarine.Cijena))
                .ForMember(x => x.DatumIsteka, b => b.MapFrom(l => l.Clanarina.DatumIsteka.ToString()))
                .ForMember(x => x.DatumUplate, b => b.MapFrom(l => l.Clanarina.DatumUplate.ToString())).ReverseMap();

            CreateMap<PlacanjeClanarine, PlacanjeClanarineUpsertRequest>().ReverseMap();

            CreateMap<Clanarina, Model.Clanarina>().ReverseMap();
            CreateMap<Clanarina, ClanarinaUpsertRequest>().ReverseMap();



            CreateMap<TipClanarine, Model.TipClanarine>().ReverseMap();

            

        }

    }
}
