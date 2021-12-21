using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyTree.Migrations
{
    public partial class Addedbirthanddeathplaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BirthPlaceId",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeathPlaceId",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BirthPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirthPlaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeathPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeathPlaces", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_BirthPlaceId",
                table: "People",
                column: "BirthPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_People_DeathPlaceId",
                table: "People",
                column: "DeathPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_BirthPlaces_BirthPlaceId",
                table: "People",
                column: "BirthPlaceId",
                principalTable: "BirthPlaces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_People_DeathPlaces_DeathPlaceId",
                table: "People",
                column: "DeathPlaceId",
                principalTable: "DeathPlaces",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_BirthPlaces_BirthPlaceId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_DeathPlaces_DeathPlaceId",
                table: "People");

            migrationBuilder.DropTable(
                name: "BirthPlaces");

            migrationBuilder.DropTable(
                name: "DeathPlaces");

            migrationBuilder.DropIndex(
                name: "IX_People_BirthPlaceId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_DeathPlaceId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "BirthPlaceId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "DeathPlaceId",
                table: "People");
        }
    }
}
