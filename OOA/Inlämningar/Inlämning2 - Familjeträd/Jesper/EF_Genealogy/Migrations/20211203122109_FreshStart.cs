using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Genealogy.Migrations
{
    public partial class FreshStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaidenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeathDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherID = table.Column<int>(type: "int", nullable: true),
                    FatherID = table.Column<int>(type: "int", nullable: true),
                    BirthLocationID = table.Column<int>(type: "int", nullable: true),
                    DeathLocationID = table.Column<int>(type: "int", nullable: true),
                    SpouseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                    table.ForeignKey(
                        name: "FK_People_Locations_BirthLocationID",
                        column: x => x.BirthLocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Locations_DeathLocationID",
                        column: x => x.DeathLocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Spouse_SpouseID",
                        column: x => x.SpouseID,
                        principalTable: "Spouse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LifeEvents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventDate = table.Column<int>(type: "int", nullable: true),
                    EventDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventPersonID = table.Column<int>(type: "int", nullable: true),
                    EventLocationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeEvents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LifeEvents_Locations_EventLocationID",
                        column: x => x.EventLocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LifeEvents_People_EventPersonID",
                        column: x => x.EventPersonID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LifeEvents_EventLocationID",
                table: "LifeEvents",
                column: "EventLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_LifeEvents_EventPersonID",
                table: "LifeEvents",
                column: "EventPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_People_BirthLocationID",
                table: "People",
                column: "BirthLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_People_DeathLocationID",
                table: "People",
                column: "DeathLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_People_SpouseID",
                table: "People",
                column: "SpouseID",
                unique: true,
                filter: "[SpouseID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LifeEvents");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Spouse");
        }
    }
}
