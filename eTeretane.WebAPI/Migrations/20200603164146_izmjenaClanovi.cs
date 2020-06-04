using Microsoft.EntityFrameworkCore.Migrations;

namespace eTeretane.WebAPI.Migrations
{
    public partial class izmjenaClanovi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradId",
                table: "Clan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clan_GradId",
                table: "Clan",
                column: "GradId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clan_Grad_GradId",
                table: "Clan",
                column: "GradId",
                principalTable: "Grad",
                principalColumn: "GradId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clan_Grad_GradId",
                table: "Clan");

            migrationBuilder.DropIndex(
                name: "IX_Clan_GradId",
                table: "Clan");

            migrationBuilder.DropColumn(
                name: "GradId",
                table: "Clan");
        }
    }
}
