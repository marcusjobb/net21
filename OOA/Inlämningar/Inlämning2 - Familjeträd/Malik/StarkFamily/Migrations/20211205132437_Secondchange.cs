using Microsoft.EntityFrameworkCore.Migrations;

namespace StarkFamily.Migrations
{
    public partial class Secondchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stark Family_Stark Family_FatherId",
                table: "Stark Family");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stark Family",
                table: "Stark Family");

            migrationBuilder.RenameTable(
                name: "Stark Family",
                newName: "Persons");

            migrationBuilder.RenameIndex(
                name: "IX_Stark Family_FatherId",
                table: "Persons",
                newName: "IX_Persons_FatherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_FatherId",
                table: "Persons",
                column: "FatherId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_FatherId",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Stark Family");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_FatherId",
                table: "Stark Family",
                newName: "IX_Stark Family_FatherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stark Family",
                table: "Stark Family",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stark Family_Stark Family_FatherId",
                table: "Stark Family",
                column: "FatherId",
                principalTable: "Stark Family",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
