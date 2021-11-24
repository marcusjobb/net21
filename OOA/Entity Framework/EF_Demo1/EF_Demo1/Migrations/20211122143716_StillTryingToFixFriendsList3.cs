using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Demo1.Migrations
{
    public partial class StillTryingToFixFriendsList3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FriendsId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FriendsId",
                table: "Players");
        }
    }
}
