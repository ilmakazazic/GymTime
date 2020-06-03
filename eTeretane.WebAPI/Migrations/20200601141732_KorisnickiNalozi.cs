using Microsoft.EntityFrameworkCore.Migrations;

namespace eTeretane.WebAPI.Migrations
{
    public partial class KorisnickiNalozi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorisniciUloge_Korisnik_KorisnikId",
                table: "KorisniciUloge");

            migrationBuilder.DropIndex(
                name: "IX_KorisniciUloge_KorisnikId",
                table: "KorisniciUloge");

            migrationBuilder.DropColumn(
                name: "KorisnickoIme",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "LozinkaHash",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "LozinkaSalt",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "KorisnikId",
                table: "KorisniciUloge");

            migrationBuilder.DropColumn(
                name: "KorisnickoIme",
                table: "Clan");

            migrationBuilder.DropColumn(
                name: "LozinkaHash",
                table: "Clan");

            migrationBuilder.DropColumn(
                name: "LozinkaSalt",
                table: "Clan");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Clan");

            migrationBuilder.AddColumn<int>(
                name: "KorisnickiNalogId",
                table: "Korisnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KorisnickiNalogId",
                table: "KorisniciUloge",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KorisnickiNalogId",
                table: "Clan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Clan",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KorisnickiNalog",
                columns: table => new
                {
                    KorisnickiNalogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiNalog", x => x.KorisnickiNalogId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_KorisnickiNalogId",
                table: "Korisnik",
                column: "KorisnickiNalogId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnickiNalogId",
                table: "KorisniciUloge",
                column: "KorisnickiNalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Clan_KorisnickiNalogId",
                table: "Clan",
                column: "KorisnickiNalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clan_KorisnickiNalog_KorisnickiNalogId",
                table: "Clan",
                column: "KorisnickiNalogId",
                principalTable: "KorisnickiNalog",
                principalColumn: "KorisnickiNalogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniciUloge_KorisnickiNalog_KorisnickiNalogId",
                table: "KorisniciUloge",
                column: "KorisnickiNalogId",
                principalTable: "KorisnickiNalog",
                principalColumn: "KorisnickiNalogId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_KorisnickiNalog_KorisnickiNalogId",
                table: "Korisnik",
                column: "KorisnickiNalogId",
                principalTable: "KorisnickiNalog",
                principalColumn: "KorisnickiNalogId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clan_KorisnickiNalog_KorisnickiNalogId",
                table: "Clan");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisniciUloge_KorisnickiNalog_KorisnickiNalogId",
                table: "KorisniciUloge");

            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_KorisnickiNalog_KorisnickiNalogId",
                table: "Korisnik");

            migrationBuilder.DropTable(
                name: "KorisnickiNalog");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_KorisnickiNalogId",
                table: "Korisnik");

            migrationBuilder.DropIndex(
                name: "IX_KorisniciUloge_KorisnickiNalogId",
                table: "KorisniciUloge");

            migrationBuilder.DropIndex(
                name: "IX_Clan_KorisnickiNalogId",
                table: "Clan");

            migrationBuilder.DropColumn(
                name: "KorisnickiNalogId",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "KorisnickiNalogId",
                table: "KorisniciUloge");

            migrationBuilder.DropColumn(
                name: "KorisnickiNalogId",
                table: "Clan");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Clan");

            migrationBuilder.AddColumn<string>(
                name: "KorisnickoIme",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaHash",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaSalt",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Korisnik",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KorisnikId",
                table: "KorisniciUloge",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "KorisnickoIme",
                table: "Clan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaHash",
                table: "Clan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaSalt",
                table: "Clan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Clan",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikId",
                table: "KorisniciUloge",
                column: "KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniciUloge_Korisnik_KorisnikId",
                table: "KorisniciUloge",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
