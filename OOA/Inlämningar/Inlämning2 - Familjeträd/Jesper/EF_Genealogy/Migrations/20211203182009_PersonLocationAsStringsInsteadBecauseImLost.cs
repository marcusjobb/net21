using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Genealogy.Migrations
{
    public partial class PersonLocationAsStringsInsteadBecauseImLost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Locations_BirthLocationID",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Locations_DeathLocationID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_BirthLocationID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_DeathLocationID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "BirthLocationID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "DeathLocationID",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "BirthLocation",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeathLocation",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthLocation",
                table: "People");

            migrationBuilder.DropColumn(
                name: "DeathLocation",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "BirthLocationID",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeathLocationID",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_BirthLocationID",
                table: "People",
                column: "BirthLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_People_DeathLocationID",
                table: "People",
                column: "DeathLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Locations_BirthLocationID",
                table: "People",
                column: "BirthLocationID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Locations_DeathLocationID",
                table: "People",
                column: "DeathLocationID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
