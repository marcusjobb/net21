using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inlämning_2_EntityFramwork.Migrations
{
    public partial class AddTommy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BirthYear",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeathYear",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Father",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mother",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthYear",
                table: "People");

            migrationBuilder.DropColumn(
                name: "DeathYear",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Father",
                table: "People");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Mother",
                table: "People");
        }
    }
}
