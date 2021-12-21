using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyTreeWF.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    BirthCityId = table.Column<int>(type: "int", nullable: true),
                    BirthCountryId = table.Column<int>(type: "int", nullable: true),
                    DeathYear = table.Column<int>(type: "int", nullable: true),
                    DeathCityId = table.Column<int>(type: "int", nullable: true),
                    DeathCountryId = table.Column<int>(type: "int", nullable: true),
                    FatherId = table.Column<int>(type: "int", nullable: true),
                    MotherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_People_Cities_BirthCityId",
                        column: x => x.BirthCityId,
                        principalTable: "Cities",
                        principalColumn: "CityId");
                    table.ForeignKey(
                        name: "FK_People_Cities_DeathCityId",
                        column: x => x.DeathCityId,
                        principalTable: "Cities",
                        principalColumn: "CityId");
                    table.ForeignKey(
                        name: "FK_People_Countries_BirthCountryId",
                        column: x => x.BirthCountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "FK_People_Countries_DeathCountryId",
                        column: x => x.DeathCountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "FK_People_People_FatherId",
                        column: x => x.FatherId,
                        principalTable: "People",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_People_People_MotherId",
                        column: x => x.MotherId,
                        principalTable: "People",
                        principalColumn: "PersonId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_BirthCityId",
                table: "People",
                column: "BirthCityId");

            migrationBuilder.CreateIndex(
                name: "IX_People_BirthCountryId",
                table: "People",
                column: "BirthCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_People_DeathCityId",
                table: "People",
                column: "DeathCityId");

            migrationBuilder.CreateIndex(
                name: "IX_People_DeathCountryId",
                table: "People",
                column: "DeathCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_People_FatherId",
                table: "People",
                column: "FatherId");

            migrationBuilder.CreateIndex(
                name: "IX_People_MotherId",
                table: "People",
                column: "MotherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
