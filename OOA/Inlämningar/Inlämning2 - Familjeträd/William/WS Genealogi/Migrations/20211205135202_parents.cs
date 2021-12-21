using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WS_Genealogi.Migrations
{
    public partial class parents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mor",
                table: "Persons",
                newName: "Mother");

            migrationBuilder.RenameColumn(
                name: "Far",
                table: "Persons",
                newName: "Father");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mother",
                table: "Persons",
                newName: "Mor");

            migrationBuilder.RenameColumn(
                name: "Father",
                table: "Persons",
                newName: "Far");
        }
    }
}
