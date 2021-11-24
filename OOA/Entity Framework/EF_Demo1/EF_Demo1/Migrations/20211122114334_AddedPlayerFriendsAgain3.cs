using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Demo1.Migrations
{
    public partial class AddedPlayerFriendsAgain3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Players_PlayerId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_PlayerId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlayerId",
                table: "Players",
                column: "PlayerId");

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
