using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTeretane.WebAPI.Migrations
{
    public partial class LicenceIspravka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumIsteka",
                table: "TrenerLicence");

            migrationBuilder.DropColumn(
                name: "DatumPolaganja",
                table: "TrenerLicence");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatumIsteka",
                table: "TrenerLicence",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumPolaganja",
                table: "TrenerLicence",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
