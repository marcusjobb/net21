using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyTree.Migrations
{
    public partial class DONE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDead",
                table: "DeathPlaces",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDead",
                table: "DeathPlaces");
        }
    }
}
