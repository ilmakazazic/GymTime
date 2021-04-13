using System;
using eTeretane.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace eTeretane.WebAPI.EF
{
    public class eTeretaneContext : DbContext
    {
        public eTeretaneContext()
        {
        }
        public eTeretaneContext(DbContextOptions<eTeretaneContext> options)
        : base(options)
        {
        }

        public DbSet<Clan> Clan { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public DbSet<Uloga> Uloga { get; set; }
        public DbSet<TipClanarine> TipClanarine { get; set; }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Licenca> Licenca { get; set; }
        public DbSet<OcjenaTeretane> OcjenaTeretane { get; set; }
        public DbSet<PlacanjeClanarine> PlacanjeClanarine { get; set; }
        public DbSet<Clanarina> Clanarina { get; set; }
        public DbSet<Teretana> Teretana { get; set; }
        public DbSet<Trening> Trening { get; set; }
        public DbSet<TreningDetalji> TreningDetalji { get; set; }
        public DbSet<TeretanaClan> TeretanaClan { get; set; }
        public DbSet<Poruke> Poruke { get; set; }
        public DbSet<TrenerLicence> TrenerLicence { get; set; }
        public DbSet<TreningZahtjev> TreningZahtjev { get; set; }
        public DbSet<KuponPopust> KuponPopust { get; set; }
        public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }
        public DbSet<TreningDodatni> TreningDodatni { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}