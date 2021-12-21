using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Genealogy.Migrations
{
    public partial class PersonInLocation : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "BirthplaceID",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_People_BirthplaceID",
                table: "People",
                column: "BirthplaceID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Locations_BirthplaceID",
                table: "People",
                column: "BirthplaceID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Locations_BirthplaceID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_BirthplaceID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "BirthplaceID",
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
