using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Genealogy.Migrations
{
    public partial class SpouseIDasIntInsteadOfSpouseObj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Spouse_SpouseID",
                table: "People");

            migrationBuilder.DropTable(
                name: "Spouse");

            migrationBuilder.DropIndex(
                name: "IX_People_SpouseID",
                table: "People");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spouse",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spouse", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_SpouseID",
                table: "People",
                column: "SpouseID",
                unique: true,
                filter: "[SpouseID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Spouse_SpouseID",
                table: "People",
                column: "SpouseID",
                principalTable: "Spouse",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
