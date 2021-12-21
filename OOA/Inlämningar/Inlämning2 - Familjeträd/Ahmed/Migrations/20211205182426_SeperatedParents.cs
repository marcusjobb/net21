using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämning2.Migrations
{
    public partial class SeperatedParents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeathDate",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Father",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mother",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "DeathDate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Father",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Mother",
                table: "People");

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Parent_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parent_PersonID",
                table: "Parent",
                column: "PersonID");
        }
    }
}
