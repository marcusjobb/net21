using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Demo1.Migrations
{
    public partial class StillTryingToFixFriendsList5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Players_Player.PlayerId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "Player.PlayerId",
                table: "Players",
                newName: "Player.Id");

            migrationBuilder.RenameIndex(
                name: "IX_Players_Player.PlayerId",
                table: "Players",
                newName: "IX_Players_Player.Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Players_Player.Id",
                table: "Players",
                column: "Player.Id",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Players_Player.Id",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "Player.Id",
                table: "Players",
                newName: "Player.PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_Player.Id",
                table: "Players",
                newName: "IX_Players_Player.PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Players_Player.PlayerId",
                table: "Players",
                column: "Player.PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
