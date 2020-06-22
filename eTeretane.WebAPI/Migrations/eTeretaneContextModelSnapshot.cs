﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eTeretane.WebAPI.EF;

namespace eTeretane.WebAPI.Migrations
{
    [DbContext(typeof(eTeretaneContext))]
    partial class eTeretaneContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eTeretane.WebAPI.Database.Clan", b =>
                {
                    b.Property<int>("ClanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRegistracije")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClanId");

                    b.HasIndex("GradId");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("Clan");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Clanarina", b =>
                {
                    b.Property<int>("ClanarinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumUplate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeretanaId")
                        .HasColumnType("int");

                    b.Property<int>("TipClanarineId")
                        .HasColumnType("int");

                    b.HasKey("ClanarinaId");

                    b.HasIndex("ClanId");

                    b.HasIndex("TeretanaId");

                    b.HasIndex("TipClanarineId");

                    b.ToTable("Clanarina");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PPT")
                        .HasColumnType("int");

                    b.HasKey("GradId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.KorisniciUloge", b =>
                {
                    b.Property<int>("KorisniciUlogeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<int>("UlogaId")
                        .HasColumnType("int");

                    b.HasKey("KorisniciUlogeId");

                    b.HasIndex("KorisnickiNalogId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisniciUloge");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.KorisnickiNalog", b =>
                {
                    b.Property<int>("KorisnickiNalogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnickiNalogId");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnikId");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.KuponPopust", b =>
                {
                    b.Property<int>("KuponPopustId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<int>("Broj_Koristenja")
                        .HasColumnType("int");

                    b.Property<DateTime>("KrajDatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("KuponKod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PocetakDatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Postotak")
                        .HasColumnType("int");

                    b.Property<int>("TeretanaId")
                        .HasColumnType("int");

                    b.HasKey("KuponPopustId");

                    b.HasIndex("TeretanaId");

                    b.ToTable("KuponPopust");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Licenca", b =>
                {
                    b.Property<int>("LicencaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LicencaId");

                    b.ToTable("Licenca");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.OcjenaTeretane", b =>
                {
                    b.Property<int>("OcjenaTeretaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<int>("TeretanaId")
                        .HasColumnType("int");

                    b.HasKey("OcjenaTeretaneId");

                    b.HasIndex("ClanId");

                    b.HasIndex("TeretanaId");

                    b.ToTable("OcjenaTeretane");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.PlacanjeClanarine", b =>
                {
                    b.Property<int>("PlacanjeClanarineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojKartice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClanarinaId")
                        .HasColumnType("int");

                    b.Property<int>("ExpMonth")
                        .HasColumnType("int");

                    b.Property<int>("ExpYear")
                        .HasColumnType("int");

                    b.Property<int>("SecurityCode")
                        .HasColumnType("int");

                    b.HasKey("PlacanjeClanarineID");

                    b.HasIndex("ClanarinaId");

                    b.ToTable("PlacanjeClanarine");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Poruke", b =>
                {
                    b.Property<int>("PorukeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumVrijeme")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Poruka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PorukeId");

                    b.HasIndex("ClanId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Poruke");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Teretana", b =>
                {
                    b.Property<int>("TeretanaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<DateTime>("KrajRadnoVrijeme")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PocetakRadnoVrijeme")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("TeretanaId");

                    b.HasIndex("GradId");

                    b.ToTable("Teretana");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TeretanaClan", b =>
                {
                    b.Property<int>("TeretanaClanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumUclanjivanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeretanaId")
                        .HasColumnType("int");

                    b.HasKey("TeretanaClanId");

                    b.HasIndex("ClanId");

                    b.HasIndex("TeretanaId");

                    b.ToTable("TeretanaClan");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TipClanarine", b =>
                {
                    b.Property<int>("TipClanarineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipClanarineId");

                    b.ToTable("TipClanarine");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TrenerLicence", b =>
                {
                    b.Property<int>("TrenerLicenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("LicencaId")
                        .HasColumnType("int");

                    b.HasKey("TrenerLicenceId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("LicencaId");

                    b.ToTable("TrenerLicence");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Trening", b =>
                {
                    b.Property<int>("TreningId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojRezervacija")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumOdrzavanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("KrajTreninga")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PocetakTreninga")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeretanaId")
                        .HasColumnType("int");

                    b.HasKey("TreningId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("TeretanaId");

                    b.ToTable("Trening");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TreningDetalji", b =>
                {
                    b.Property<int>("TreningDetaljiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<bool>("Otkazan")
                        .HasColumnType("bit");

                    b.Property<int>("TreningId")
                        .HasColumnType("int");

                    b.HasKey("TreningDetaljiId");

                    b.HasIndex("ClanId");

                    b.HasIndex("TreningId");

                    b.ToTable("TreningDetalji");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TreningDodatni", b =>
                {
                    b.Property<int>("TreningDodatniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumOdrzavanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("KrajTreninga")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PocetakTreninga")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Prihvacen")
                        .HasColumnType("bit");

                    b.Property<int>("TeretanaId")
                        .HasColumnType("int");

                    b.HasKey("TreningDodatniId");

                    b.HasIndex("ClanId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("TeretanaId");

                    b.ToTable("TreningDodatni");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TreningZahtjev", b =>
                {
                    b.Property<int>("TreningZahtjevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<bool>("Odobren")
                        .HasColumnType("bit");

                    b.Property<int>("TreningId")
                        .HasColumnType("int");

                    b.HasKey("TreningZahtjevId");

                    b.HasIndex("ClanId");

                    b.HasIndex("TreningId");

                    b.ToTable("TreningZahtjev");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Uloga", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlogaId");

                    b.ToTable("Uloga");
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Clan", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Clanarina", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Teretana", "Teretana")
                        .WithMany()
                        .HasForeignKey("TeretanaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.TipClanarine", "TipClanarine")
                        .WithMany()
                        .HasForeignKey("TipClanarineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Grad", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.KorisniciUloge", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Uloga", "Uloga")
                        .WithMany()
                        .HasForeignKey("UlogaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Korisnik", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.KuponPopust", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Teretana", "Teretana")
                        .WithMany()
                        .HasForeignKey("TeretanaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.OcjenaTeretane", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Teretana", "Teretana")
                        .WithMany()
                        .HasForeignKey("TeretanaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.PlacanjeClanarine", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Clanarina", "Clanarina")
                        .WithMany()
                        .HasForeignKey("ClanarinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Poruke", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Teretana", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TeretanaClan", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Teretana", "Teretana")
                        .WithMany()
                        .HasForeignKey("TeretanaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TrenerLicence", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Licenca", "Licenca")
                        .WithMany()
                        .HasForeignKey("LicencaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.Trening", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Teretana", "Teretana")
                        .WithMany()
                        .HasForeignKey("TeretanaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TreningDetalji", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Trening", "Trening")
                        .WithMany()
                        .HasForeignKey("TreningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TreningDodatni", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Teretana", "Teretana")
                        .WithMany()
                        .HasForeignKey("TeretanaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTeretane.WebAPI.Database.TreningZahtjev", b =>
                {
                    b.HasOne("eTeretane.WebAPI.Database.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTeretane.WebAPI.Database.Trening", "Trening")
                        .WithMany()
                        .HasForeignKey("TreningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
