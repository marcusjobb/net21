using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Demo1.Migrations
{
    public partial class AddedNameToHiScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "HiScores",
                type: "nvarchar(50)",
                nullable: true , 
                defaultValue: "player");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "HiScores");
        }
    }
}
