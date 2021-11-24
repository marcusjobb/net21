using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Demo1.Migrations
{
    public partial class StillTryingToFixFriendsList6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Players_Player.Id",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_Player.Id",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Player.Id",
                table: "Players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Player.Id",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_Player.Id",
                table: "Players",
                column: "Player.Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Players_Player.Id",
                table: "Players",
                column: "Player.Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
