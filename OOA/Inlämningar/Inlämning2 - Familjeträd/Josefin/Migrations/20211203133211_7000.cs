using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Genealogi_OOA_JosefinPersson.Migrations
{
    public partial class _7000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaidenName",
                table: "People");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "People");

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeathDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_People_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.AddColumn<string>(
                name: "MaidenName",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
