using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarkFamily.Migrations
{
    public partial class Fifthchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stark Family",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeathDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FatherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stark Family", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stark Family_Stark Family_FatherId",
                        column: x => x.FatherId,
                        principalTable: "Stark Family",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stark Family_FatherId",
                table: "Stark Family",
                column: "FatherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stark Family");
        }
    }
}
