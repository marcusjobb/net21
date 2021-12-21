using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Family.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    House = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Male = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegnalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoyalEpithet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfDeath = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeathPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Father = table.Column<int>(type: "int", nullable: true),
                    Mother = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
