using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTeretane.WebAPI.Migrations
{
    public partial class Placanja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojRacuna",
                table: "PlacanjeClanarine");

            migrationBuilder.DropColumn(
                name: "DatumUplate",
                table: "PlacanjeClanarine");

            migrationBuilder.DropColumn(
                name: "UkupanIznos",
                table: "PlacanjeClanarine");

            migrationBuilder.AddColumn<long>(
                name: "BrojKartice",
                table: "PlacanjeClanarine",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "ExpMonth",
                table: "PlacanjeClanarine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpYear",
                table: "PlacanjeClanarine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecurityCode",
                table: "PlacanjeClanarine",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojKartice",
                table: "PlacanjeClanarine");

            migrationBuilder.DropColumn(
                name: "ExpMonth",
                table: "PlacanjeClanarine");

            migrationBuilder.DropColumn(
                name: "ExpYear",
                table: "PlacanjeClanarine");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "PlacanjeClanarine");

            migrationBuilder.AddColumn<int>(
                name: "BrojRacuna",
                table: "PlacanjeClanarine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumUplate",
                table: "PlacanjeClanarine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "UkupanIznos",
                table: "PlacanjeClanarine",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
