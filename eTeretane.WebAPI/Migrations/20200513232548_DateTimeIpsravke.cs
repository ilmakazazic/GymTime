using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTeretane.WebAPI.Migrations
{
    public partial class DateTimeIpsravke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PocetakTreninga",
                table: "Trening",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "KrajTreninga",
                table: "Trening",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "PocetakTreninga",
                table: "Trening",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "KrajTreninga",
                table: "Trening",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
