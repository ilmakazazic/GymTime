using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTeretane.WebAPI.Migrations
{
    public partial class NovaTabela_TreningDodatni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TreningDodatni",
                columns: table => new
                {
                    TreningDodatniId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOdrzavanja = table.Column<DateTime>(nullable: false),
                    PocetakTreninga = table.Column<DateTime>(nullable: false),
                    KrajTreninga = table.Column<DateTime>(nullable: false),
                    TeretanaId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    ClanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreningDodatni", x => x.TreningDodatniId);
                    table.ForeignKey(
                        name: "FK_TreningDodatni_Clan_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clan",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreningDodatni_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreningDodatni_Teretana_TeretanaId",
                        column: x => x.TeretanaId,
                        principalTable: "Teretana",
                        principalColumn: "TeretanaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TreningDodatni_ClanId",
                table: "TreningDodatni",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_TreningDodatni_KorisnikId",
                table: "TreningDodatni",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_TreningDodatni_TeretanaId",
                table: "TreningDodatni",
                column: "TeretanaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TreningDodatni");
        }
    }
}
