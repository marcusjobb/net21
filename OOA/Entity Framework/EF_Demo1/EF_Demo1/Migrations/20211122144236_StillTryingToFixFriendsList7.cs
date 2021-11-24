using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Demo1.Migrations
{
    public partial class StillTryingToFixFriendsList7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FriendId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_FriendId",
                table: "Players",
                column: "FriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Players_FriendId",
                table: "Players",
                column: "FriendId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Players_FriendId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_FriendId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "FriendId",
                table: "Players");
        }
    }
}
