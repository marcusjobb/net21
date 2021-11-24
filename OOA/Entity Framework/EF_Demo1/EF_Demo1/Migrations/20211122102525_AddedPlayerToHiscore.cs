using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Demo1.Migrations
{
    public partial class AddedPlayerToHiscore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "HiScores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HiScores_PlayerId",
                table: "HiScores",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_HiScores_Players_PlayerId",
                table: "HiScores",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HiScores_Players_PlayerId",
                table: "HiScores");

            migrationBuilder.DropIndex(
                name: "IX_HiScores_PlayerId",
                table: "HiScores");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "HiScores");
        }
    }
}
