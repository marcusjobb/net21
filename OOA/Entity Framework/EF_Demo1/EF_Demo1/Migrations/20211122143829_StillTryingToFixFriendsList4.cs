using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Demo1.Migrations
{
    public partial class StillTryingToFixFriendsList4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Players_PlayerId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "FriendsId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Players",
                newName: "Player.PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_PlayerId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Players_Player.PlayerId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "Player.PlayerId",
                table: "Players",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_Player.PlayerId",
                table: "Players",
                newName: "IX_Players_PlayerId");

            migrationBuilder.AddColumn<int>(
                name: "FriendsId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Players_PlayerId",
                table: "Players",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
