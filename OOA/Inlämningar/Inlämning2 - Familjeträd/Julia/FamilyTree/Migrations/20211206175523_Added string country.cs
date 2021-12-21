using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyTree.Migrations
{
    public partial class Addedstringcountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "DeathPlaces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "BirthPlaces",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "DeathPlaces");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "BirthPlaces");
        }
    }
}
