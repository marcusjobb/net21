using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WS_Genealogi.Migrations
{
    public partial class SecondDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DeathDate",
                table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeathDate",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
