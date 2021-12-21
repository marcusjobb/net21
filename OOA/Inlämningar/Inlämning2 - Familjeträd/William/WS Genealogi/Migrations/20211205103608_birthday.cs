using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WS_Genealogi.Migrations
{
    public partial class birthday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Birthday",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Persons");
        }
    }
}
