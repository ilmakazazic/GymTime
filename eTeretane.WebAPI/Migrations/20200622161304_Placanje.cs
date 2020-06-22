using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTeretane.WebAPI.Migrations
{
    public partial class Placanje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlacanjeClanarine_Clan_ClanId",
                table: "PlacanjeClanarine");

            migrationBuilder.DropForeignKey(
                name: "FK_PlacanjeClanarine_Teretana_TeretanaId",
                table: "PlacanjeClanarine");

            migrationBuilder.DropForeignKey(
                name: "FK_PlacanjeClanarine_TipClanarine_TipClanarineId",
                table: "PlacanjeClanarine");

            migrationBuilder.DropIndex(
                name: "IX_PlacanjeClanarine_ClanId",
                table: "PlacanjeClanarine");

            migrationBuilder.DropIndex(
                name: "IX_PlacanjeClanarine_TeretanaId",
                table: "PlacanjeClanarine");

            migrationBuilder.DropIndex(
                name: "IX_PlacanjeClanarine_TipClanarineId",
                table: "PlacanjeClanarine");

            migrationBuilder.DropColumn(
                name: "ClanId",
                table: "PlacanjeClanarine");

            migrationBuilder.DropColumn(
                name: "TeretanaId",
                table: "PlacanjeClanarine");

            migrationBuilder.DropColumn(
                name: "TipClanarineId",
                table: "PlacanjeClanarine");

            migrationBuilder.AddColumn<int>(
                name: "ClanarinaId",
                table: "PlacanjeClanarine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Clanarina",
                columns: table => new
                {
                    ClanarinaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumUplate = table.Column<DateTime>(nullable: false),
                    DatumIsteka = table.Column<DateTime>(nullable: false),
                    TipClanarineId = table.Column<int>(nullable: false),
                    ClanId = table.Column<int>(nullable: false),
                    TeretanaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanarina", x => x.ClanarinaId);
                    table.ForeignKey(
                        name: "FK_Clanarina_Clan_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clan",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clanarina_Teretana_TeretanaId",
                        column: x => x.TeretanaId,
                        principalTable: "Teretana",
                        principalColumn: "TeretanaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clanarina_TipClanarine_TipClanarineId",
                        column: x => x.TipClanarineId,
                        principalTable: "TipClanarine",
                        principalColumn: "TipClanarineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlacanjeClanarine_ClanarinaId",
                table: "PlacanjeClanarine",
                column: "ClanarinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanarina_ClanId",
                table: "Clanarina",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanarina_TeretanaId",
                table: "Clanarina",
                column: "TeretanaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanarina_TipClanarineId",
                table: "Clanarina",
                column: "TipClanarineId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlacanjeClanarine_Clanarina_ClanarinaId",
                table: "PlacanjeClanarine",
                column: "ClanarinaId",
                principalTable: "Clanarina",
                principalColumn: "ClanarinaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlacanjeClanarine_Clanarina_ClanarinaId",
                table: "PlacanjeClanarine");

            migrationBuilder.DropTable(
                name: "Clanarina");

            migrationBuilder.DropIndex(
                name: "IX_PlacanjeClanarine_ClanarinaId",
                table: "PlacanjeClanarine");

            migrationBuilder.DropColumn(
                name: "ClanarinaId",
                table: "PlacanjeClanarine");

            migrationBuilder.AddColumn<int>(
                name: "ClanId",
                table: "PlacanjeClanarine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeretanaId",
                table: "PlacanjeClanarine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipClanarineId",
                table: "PlacanjeClanarine",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_PlacanjeClanarine_Clan_ClanId",
                table: "PlacanjeClanarine",
                column: "ClanId",
                principalTable: "Clan",
                principalColumn: "ClanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlacanjeClanarine_Teretana_TeretanaId",
                table: "PlacanjeClanarine",
                column: "TeretanaId",
                principalTable: "Teretana",
                principalColumn: "TeretanaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlacanjeClanarine_TipClanarine_TipClanarineId",
                table: "PlacanjeClanarine",
                column: "TipClanarineId",
                principalTable: "TipClanarine",
                principalColumn: "TipClanarineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
