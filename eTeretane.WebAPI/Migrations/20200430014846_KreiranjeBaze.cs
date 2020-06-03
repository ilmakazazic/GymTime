using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTeretane.WebAPI.Migrations
{
    public partial class KreiranjeBaze : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clan",
                columns: table => new
                {
                    ClanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumRegistracije = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clan", x => x.ClanId);
                });

            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Licenca",
                columns: table => new
                {
                    LicencaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenca", x => x.LicencaId);
                });

            migrationBuilder.CreateTable(
                name: "TipClanarine",
                columns: table => new
                {
                    TipClanarineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipClanarine", x => x.TipClanarineId);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    PPT = table.Column<int>(nullable: false),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradId);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Poruke",
                columns: table => new
                {
                    PorukeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Poruka = table.Column<string>(nullable: true),
                    DatumVrijeme = table.Column<DateTime>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    ClanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruke", x => x.PorukeId);
                    table.ForeignKey(
                        name: "FK_Poruke_Clan_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clan",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Poruke_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrenerLicence",
                columns: table => new
                {
                    TrenerLicenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPolaganja = table.Column<DateTime>(nullable: false),
                    DatumIsteka = table.Column<DateTime>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    LicencaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrenerLicence", x => x.TrenerLicenceId);
                    table.ForeignKey(
                        name: "FK_TrenerLicence_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrenerLicence_Licenca_LicencaId",
                        column: x => x.LicencaId,
                        principalTable: "Licenca",
                        principalColumn: "LicencaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisniciUlogeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumIzmjene = table.Column<DateTime>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    UlogaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisniciUlogeId);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloga_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teretana",
                columns: table => new
                {
                    TeretanaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    PocetakRadnoVrijeme = table.Column<TimeSpan>(nullable: false),
                    KrajRadnoVrijeme = table.Column<TimeSpan>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    SlikaThumb = table.Column<byte[]>(nullable: true),
                    GradId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teretana", x => x.TeretanaId);
                    table.ForeignKey(
                        name: "FK_Teretana_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KuponPopust",
                columns: table => new
                {
                    KuponPopustId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KuponKod = table.Column<string>(nullable: true),
                    Postotak = table.Column<int>(nullable: false),
                    PocetakDatum = table.Column<DateTime>(nullable: false),
                    KrajDatum = table.Column<DateTime>(nullable: false),
                    Broj_Koristenja = table.Column<int>(nullable: false),
                    Aktivan = table.Column<bool>(nullable: false),
                    TeretanaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KuponPopust", x => x.KuponPopustId);
                    table.ForeignKey(
                        name: "FK_KuponPopust_Teretana_TeretanaId",
                        column: x => x.TeretanaId,
                        principalTable: "Teretana",
                        principalColumn: "TeretanaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OcjenaTeretane",
                columns: table => new
                {
                    OcjenaTeretaneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(nullable: false),
                    TeretanaId = table.Column<int>(nullable: false),
                    ClanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcjenaTeretane", x => x.OcjenaTeretaneId);
                    table.ForeignKey(
                        name: "FK_OcjenaTeretane_Clan_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clan",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OcjenaTeretane_Teretana_TeretanaId",
                        column: x => x.TeretanaId,
                        principalTable: "Teretana",
                        principalColumn: "TeretanaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlacanjeClanarine",
                columns: table => new
                {
                    PlacanjeClanarineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojRacuna = table.Column<int>(nullable: false),
                    UkupanIznos = table.Column<double>(nullable: false),
                    DatumUplate = table.Column<DateTime>(nullable: false),
                    TipClanarineId = table.Column<int>(nullable: false),
                    ClanId = table.Column<int>(nullable: false),
                    TeretanaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacanjeClanarine", x => x.PlacanjeClanarineID);
                    table.ForeignKey(
                        name: "FK_PlacanjeClanarine_Clan_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clan",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlacanjeClanarine_Teretana_TeretanaId",
                        column: x => x.TeretanaId,
                        principalTable: "Teretana",
                        principalColumn: "TeretanaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlacanjeClanarine_TipClanarine_TipClanarineId",
                        column: x => x.TipClanarineId,
                        principalTable: "TipClanarine",
                        principalColumn: "TipClanarineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeretanaClan",
                columns: table => new
                {
                    TeretanaClanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumUclanjivanja = table.Column<DateTime>(nullable: false),
                    TeretanaId = table.Column<int>(nullable: false),
                    ClanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeretanaClan", x => x.TeretanaClanId);
                    table.ForeignKey(
                        name: "FK_TeretanaClan_Clan_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clan",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeretanaClan_Teretana_TeretanaId",
                        column: x => x.TeretanaId,
                        principalTable: "Teretana",
                        principalColumn: "TeretanaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trening",
                columns: table => new
                {
                    TreningId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOdrzavanja = table.Column<DateTime>(nullable: false),
                    PocetakTreninga = table.Column<TimeSpan>(nullable: false),
                    KrajTreninga = table.Column<TimeSpan>(nullable: false),
                    BrojRezervacija = table.Column<int>(nullable: false),
                    TeretanaId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trening", x => x.TreningId);
                    table.ForeignKey(
                        name: "FK_Trening_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trening_Teretana_TeretanaId",
                        column: x => x.TeretanaId,
                        principalTable: "Teretana",
                        principalColumn: "TeretanaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreningDetalji",
                columns: table => new
                {
                    TreningDetaljiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Otkazan = table.Column<bool>(nullable: false),
                    TreningId = table.Column<int>(nullable: false),
                    ClanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreningDetalji", x => x.TreningDetaljiId);
                    table.ForeignKey(
                        name: "FK_TreningDetalji_Clan_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clan",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreningDetalji_Trening_TreningId",
                        column: x => x.TreningId,
                        principalTable: "Trening",
                        principalColumn: "TreningId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreningZahtjev",
                columns: table => new
                {
                    TreningZahtjevId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClanId = table.Column<int>(nullable: false),
                    TreningId = table.Column<int>(nullable: false),
                    Odobren = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreningZahtjev", x => x.TreningZahtjevId);
                    table.ForeignKey(
                        name: "FK_TreningZahtjev_Clan_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clan",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreningZahtjev_Trening_TreningId",
                        column: x => x.TreningId,
                        principalTable: "Trening",
                        principalColumn: "TreningId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaId",
                table: "Grad",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikId",
                table: "KorisniciUloge",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaId",
                table: "KorisniciUloge",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_KuponPopust_TeretanaId",
                table: "KuponPopust",
                column: "TeretanaId");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenaTeretane_ClanId",
                table: "OcjenaTeretane",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenaTeretane_TeretanaId",
                table: "OcjenaTeretane",
                column: "TeretanaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacanjeClanarine_ClanId",
                table: "PlacanjeClanarine",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacanjeClanarine_TeretanaId",
                table: "PlacanjeClanarine",
                column: "TeretanaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacanjeClanarine_TipClanarineId",
                table: "PlacanjeClanarine",
                column: "TipClanarineId");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_ClanId",
                table: "Poruke",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_Poruke_KorisnikId",
                table: "Poruke",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Teretana_GradId",
                table: "Teretana",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_TeretanaClan_ClanId",
                table: "TeretanaClan",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_TeretanaClan_TeretanaId",
                table: "TeretanaClan",
                column: "TeretanaId");

            migrationBuilder.CreateIndex(
                name: "IX_TrenerLicence_KorisnikId",
                table: "TrenerLicence",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_TrenerLicence_LicencaId",
                table: "TrenerLicence",
                column: "LicencaId");

            migrationBuilder.CreateIndex(
                name: "IX_Trening_KorisnikId",
                table: "Trening",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Trening_TeretanaId",
                table: "Trening",
                column: "TeretanaId");

            migrationBuilder.CreateIndex(
                name: "IX_TreningDetalji_ClanId",
                table: "TreningDetalji",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_TreningDetalji_TreningId",
                table: "TreningDetalji",
                column: "TreningId");

            migrationBuilder.CreateIndex(
                name: "IX_TreningZahtjev_ClanId",
                table: "TreningZahtjev",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_TreningZahtjev_TreningId",
                table: "TreningZahtjev",
                column: "TreningId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "KuponPopust");

            migrationBuilder.DropTable(
                name: "OcjenaTeretane");

            migrationBuilder.DropTable(
                name: "PlacanjeClanarine");

            migrationBuilder.DropTable(
                name: "Poruke");

            migrationBuilder.DropTable(
                name: "TeretanaClan");

            migrationBuilder.DropTable(
                name: "TrenerLicence");

            migrationBuilder.DropTable(
                name: "TreningDetalji");

            migrationBuilder.DropTable(
                name: "TreningZahtjev");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "TipClanarine");

            migrationBuilder.DropTable(
                name: "Licenca");

            migrationBuilder.DropTable(
                name: "Clan");

            migrationBuilder.DropTable(
                name: "Trening");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Teretana");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
