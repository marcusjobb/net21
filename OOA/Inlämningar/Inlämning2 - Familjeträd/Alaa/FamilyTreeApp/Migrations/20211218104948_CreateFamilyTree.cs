using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyTreeApp.Migrations
{
    public partial class CreateFamilyTree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aunts",
                columns: table => new
                {
                    auntID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    auntFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    auntLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aunts", x => x.auntID);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    childID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    childFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    childLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.childID);
                });

            migrationBuilder.CreateTable(
                name: "Cousins",
                columns: table => new
                {
                    cousinID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cousinFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cousinLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cousins", x => x.cousinID);
                });

            migrationBuilder.CreateTable(
                name: "GrandFathers",
                columns: table => new
                {
                    grandFatherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grandFatherFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    grandFatherLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrandFathers", x => x.grandFatherID);
                });

            migrationBuilder.CreateTable(
                name: "GrandMothers",
                columns: table => new
                {
                    grandMotherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grandMotherFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    grandMotherLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrandMothers", x => x.grandMotherID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    personID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.personID);
                });

            migrationBuilder.CreateTable(
                name: "Siblings",
                columns: table => new
                {
                    siblingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    siblingFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    siblingLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siblings", x => x.siblingID);
                });

            migrationBuilder.CreateTable(
                name: "Uncles",
                columns: table => new
                {
                    uncleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uncleFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uncleLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uncles", x => x.uncleID);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    addressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<int>(type: "int", nullable: false),
                    DethDate = table.Column<int>(type: "int", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.addressID);
                    table.ForeignKey(
                        name: "FK_Addresses_Persons_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "auntperson",
                columns: table => new
                {
                    peoplepersonID = table.Column<int>(type: "int", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auntperson", x => new { x.peoplepersonID, x.personIDFK });
                    table.ForeignKey(
                        name: "FK_auntperson_Aunts_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "Aunts",
                        principalColumn: "auntID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_auntperson_Persons_peoplepersonID",
                        column: x => x.peoplepersonID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "childrenperson",
                columns: table => new
                {
                    peoplepersonID = table.Column<int>(type: "int", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_childrenperson", x => new { x.peoplepersonID, x.personIDFK });
                    table.ForeignKey(
                        name: "FK_childrenperson_Children_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "Children",
                        principalColumn: "childID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_childrenperson_Persons_peoplepersonID",
                        column: x => x.peoplepersonID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cousinperson",
                columns: table => new
                {
                    peoplepersonID = table.Column<int>(type: "int", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cousinperson", x => new { x.peoplepersonID, x.personIDFK });
                    table.ForeignKey(
                        name: "FK_cousinperson_Cousins_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "Cousins",
                        principalColumn: "cousinID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cousinperson_Persons_peoplepersonID",
                        column: x => x.peoplepersonID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fathers",
                columns: table => new
                {
                    fatherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fatherFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fatherLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fathers", x => x.fatherID);
                    table.ForeignKey(
                        name: "FK_Fathers_Persons_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "grandFatherperson",
                columns: table => new
                {
                    peoplepersonID = table.Column<int>(type: "int", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grandFatherperson", x => new { x.peoplepersonID, x.personIDFK });
                    table.ForeignKey(
                        name: "FK_grandFatherperson_GrandFathers_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "GrandFathers",
                        principalColumn: "grandFatherID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_grandFatherperson_Persons_peoplepersonID",
                        column: x => x.peoplepersonID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "grandMotherperson",
                columns: table => new
                {
                    peoplepersonID = table.Column<int>(type: "int", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grandMotherperson", x => new { x.peoplepersonID, x.personIDFK });
                    table.ForeignKey(
                        name: "FK_grandMotherperson_GrandMothers_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "GrandMothers",
                        principalColumn: "grandMotherID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_grandMotherperson_Persons_peoplepersonID",
                        column: x => x.peoplepersonID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mothers",
                columns: table => new
                {
                    motherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    motherFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    motherLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mothers", x => x.motherID);
                    table.ForeignKey(
                        name: "FK_Mothers_Persons_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spouses",
                columns: table => new
                {
                    spouseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    spouseFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    spouseLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spouses", x => x.spouseID);
                    table.ForeignKey(
                        name: "FK_Spouses_Persons_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "personsibling",
                columns: table => new
                {
                    peoplepersonID = table.Column<int>(type: "int", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personsibling", x => new { x.peoplepersonID, x.personIDFK });
                    table.ForeignKey(
                        name: "FK_personsibling_Persons_peoplepersonID",
                        column: x => x.peoplepersonID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personsibling_Siblings_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "Siblings",
                        principalColumn: "siblingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "personuncle",
                columns: table => new
                {
                    peoplepersonID = table.Column<int>(type: "int", nullable: false),
                    personIDFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personuncle", x => new { x.peoplepersonID, x.personIDFK });
                    table.ForeignKey(
                        name: "FK_personuncle_Persons_peoplepersonID",
                        column: x => x.peoplepersonID,
                        principalTable: "Persons",
                        principalColumn: "personID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personuncle_Uncles_personIDFK",
                        column: x => x.personIDFK,
                        principalTable: "Uncles",
                        principalColumn: "uncleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aunts",
                columns: new[] { "auntID", "auntFirstName", "auntLastName", "personIDFK" },
                values: new object[,]
                {
                    { 1, "Petunia", "Evans", 1 },
                    { 2, "Lily", "Evans", 10 },
                    { 3, "Fleur", "Delacour", 5 },
                    { 4, "Fleur", "Delacour", 6 },
                    { 5, "Fleur", "Delacour", 7 },
                    { 6, "Ginevra", "Weasley", 25 },
                    { 7, "Ginevra", "Weasley", 26 },
                    { 8, "Ginevra", "Weasley", 27 }
                });

            migrationBuilder.InsertData(
                table: "Children",
                columns: new[] { "childID", "childFirstName", "childLastName", "personIDFK" },
                values: new object[,]
                {
                    { 1, "Harry", "Potter", 3 },
                    { 2, "Harry", "Potter", 4 },
                    { 3, "Ginevra", "Weasley", 13 },
                    { 4, "Ginevra", "Weasley", 14 },
                    { 5, "James", "Potter", 11 },
                    { 6, "James", "Potter", 12 },
                    { 7, "James", "Potter", 1 },
                    { 8, "James", "Potter", 2 },
                    { 9, "Albus", "Potter", 1 },
                    { 10, "Albus", "Potter", 2 },
                    { 11, "Luna", "Potter", 1 },
                    { 12, "Luna", "Potter", 2 },
                    { 13, "Ronald", "Weasley", 13 },
                    { 14, "Ronald", "Weasley", 14 },
                    { 15, "George", "Weasley", 13 },
                    { 16, "George", "Weasley", 14 },
                    { 17, "Fred", "Weasley", 13 },
                    { 18, "Fred", "Weasley", 14 },
                    { 19, "Percival", "Weasley", 13 },
                    { 20, "Percival", "Weasley", 14 },
                    { 21, "Charlie", "Weasley", 13 },
                    { 22, "Charlie", "Weasley", 14 },
                    { 23, "Bill", "Weasley", 13 },
                    { 24, "Bill", "Weasley", 14 },
                    { 25, "Victoire", "Weasley", 20 },
                    { 26, "Victoire", "Weasley", 24 },
                    { 27, "Dominique", "Weasley", 20 },
                    { 28, "Dominique", "Weasley", 24 },
                    { 29, "Louis", "Weasley", 20 },
                    { 30, "Louis", "Weasley", 24 },
                    { 31, "Arthur", "Weasley", 21 },
                    { 32, "Arthur", "Weasley", 22 },
                    { 33, "Dudley", "Dursley", 8 },
                    { 34, "Dudley", "Dursley", 9 }
                });

            migrationBuilder.InsertData(
                table: "Cousins",
                columns: new[] { "cousinID", "cousinFirstName", "cousinLastName", "personIDFK" },
                values: new object[,]
                {
                    { 1, "James", "Potter", 10 },
                    { 2, "Albus", "Potter", 10 },
                    { 3, "Luna", "Potter", 10 },
                    { 4, "James", "Potter", 25 },
                    { 5, "Albus", "Potter", 25 },
                    { 6, "Luna", "Potter", 25 },
                    { 7, "James", "Potter", 26 },
                    { 8, "Albus", "Potter", 26 },
                    { 9, "Luna", "Potter", 26 },
                    { 10, "James", "Potter", 27 },
                    { 11, "Albus", "Potter", 27 },
                    { 12, "Luna", "Potter", 27 },
                    { 13, "Dudley", "Dursley", 5 },
                    { 14, "Dudley", "Dursley", 6 },
                    { 15, "Dudley", "Dursley", 7 },
                    { 16, "Victoire", "Weasley", 7 },
                    { 17, "Dominique", "Weasley", 7 },
                    { 18, "Louis", "Weasley", 7 },
                    { 19, "Victoire", "Weasley", 6 },
                    { 20, "Dominique", "Weasley", 6 },
                    { 21, "Louis", "Weasley", 6 },
                    { 22, "Victoire", "Weasley", 5 },
                    { 23, "Dominique", "Weasley", 5 },
                    { 24, "Louis", "Weasley", 5 }
                });

            migrationBuilder.InsertData(
                table: "GrandFathers",
                columns: new[] { "grandFatherID", "grandFatherFirstName", "grandFatherLastName", "personIDFK" },
                values: new object[,]
                {
                    { 1, "Flearnont", "Potter", 1 },
                    { 2, "James", "POtter", 5 },
                    { 3, "James", "POtter", 6 },
                    { 4, "James", "POtter", 7 },
                    { 5, "Arthur", "Weasley", 5 },
                    { 6, "Arthur", "Weasley", 6 },
                    { 7, "Arthur", "Weasley", 7 },
                    { 8, "Arthur", "Weasley", 25 },
                    { 9, "Arthur", "Weasley", 26 },
                    { 10, "Arthur", "Weasley", 27 },
                    { 11, "Arthur", "Weasley", 2 },
                    { 12, "Arthur", "Weasley", 2 },
                    { 13, "Seplimus", "Weasley", 2 },
                    { 14, "Seplimus", "Weasley", 15 },
                    { 15, "Seplimus", "Weasley", 16 },
                    { 16, "Seplimus", "Weasley", 17 },
                    { 17, "Seplimus", "Weasley", 18 },
                    { 18, "Seplimus", "Weasley", 19 }
                });

            migrationBuilder.InsertData(
                table: "GrandFathers",
                columns: new[] { "grandFatherID", "grandFatherFirstName", "grandFatherLastName", "personIDFK" },
                values: new object[] { 19, "Seplimus", "Weasley", 20 });

            migrationBuilder.InsertData(
                table: "GrandMothers",
                columns: new[] { "grandMotherID", "grandMotherFirstName", "grandMotherLastName", "personIDFK" },
                values: new object[,]
                {
                    { 1, "Euphernia", "", 1 },
                    { 2, "Lily", "Evans", 5 },
                    { 3, "Lily", "Evans", 6 },
                    { 4, "Lily", "Evans", 7 },
                    { 5, "Molly", "Prewett", 5 },
                    { 6, "Molly", "Prewett", 6 },
                    { 7, "Molly", "Prewett", 7 },
                    { 8, "Molly", "Prewett", 25 },
                    { 9, "Molly", "Prewett", 26 },
                    { 10, "Molly", "Prewett", 27 },
                    { 11, "Cidrella", "Black", 2 },
                    { 12, "Cidrella", "Black", 15 },
                    { 13, "Cidrella", "Black", 16 },
                    { 14, "Cidrella", "Black", 17 },
                    { 15, "Cidrella", "Black", 18 },
                    { 16, "Cidrella", "Black", 19 },
                    { 17, "Cidrella", "Black", 20 }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "personID", "Gender", "Status", "firstName", "lastName" },
                values: new object[,]
                {
                    { 1, 0, 1, "Harry", "Potter" },
                    { 2, 1, 1, "Ginevra", "Weasley" },
                    { 3, 0, 1, "James", "Potter" },
                    { 4, 1, 1, "Lily", "Evans" },
                    { 5, 0, 0, "James", "Potter" },
                    { 6, 0, 0, "Albus", "Potter" },
                    { 7, 1, 0, "Luna", "Potter" },
                    { 8, 1, 1, "Petunia", "Evans" },
                    { 9, 0, 1, "Vernon", "Dursley" },
                    { 10, 0, 0, "Dudley", "Dursley" },
                    { 11, 1, 4, "Euphemia", "" },
                    { 12, 0, 1, "Fleamount", "Potter" },
                    { 13, 1, 1, "Molly", "Prewett" },
                    { 14, 0, 1, "Arthur", "Weasley" },
                    { 15, 0, 0, "Ronald", "Weasley" },
                    { 16, 0, 4, "George", "Weasley" },
                    { 17, 0, 4, "Fred", "Weasley" },
                    { 18, 0, 4, "Percival", "Weasley" },
                    { 19, 0, 4, "Charile", "Weasley" },
                    { 20, 0, 4, "Bill", "Weasley" },
                    { 21, 0, 1, "Septimus", "Weasley" },
                    { 22, 1, 1, "Cedrella", "Blach" },
                    { 23, 1, 4, "Bilius", "Weasley" },
                    { 24, 1, 1, "Fleur", "Delacour" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "personID", "Gender", "Status", "firstName", "lastName" },
                values: new object[,]
                {
                    { 25, 1, 4, "Victorie", "Weasley" },
                    { 26, 1, 4, "Dominique", "Weasley" },
                    { 27, 0, 4, "Louis", "Weasley" }
                });

            migrationBuilder.InsertData(
                table: "Siblings",
                columns: new[] { "siblingID", "personIDFK", "siblingFirstName", "siblingLastName" },
                values: new object[,]
                {
                    { 1, 8, "Lily", "Evans" },
                    { 2, 6, "James", "Potter" },
                    { 3, 7, "James", "Potter" },
                    { 4, 5, "Albus", "Potter" },
                    { 5, 7, "Albus", "Potter" },
                    { 6, 5, "Luna", "Potter" },
                    { 7, 6, "Luna", "Potter" },
                    { 8, 4, "Petuna", "Evans" },
                    { 9, 15, "Ginevra", "Weasley" },
                    { 10, 16, "Ginevra", "Weasley" },
                    { 11, 17, "Ginevra", "Weasley" },
                    { 12, 18, "Ginevra", "Weasley" },
                    { 13, 19, "Ginevra", "Weasley" },
                    { 14, 20, "Ginevra", "Weasley" },
                    { 15, 2, "Ronald", "Weasley" },
                    { 16, 16, "Ronald", "Weasley" },
                    { 17, 17, "Ronald", "Weasley" },
                    { 18, 18, "Ronald", "Weasley" },
                    { 19, 19, "Ronald", "Weasley" },
                    { 20, 20, "Ronald", "Weasley" },
                    { 21, 2, "George", "Weasley" },
                    { 22, 15, "George", "Weasley" },
                    { 23, 17, "George", "Weasley" },
                    { 24, 18, "George", "Weasley" },
                    { 25, 19, "George", "Weasley" },
                    { 26, 20, "George", "Weasley" },
                    { 27, 2, "Fred", "Weasley" },
                    { 28, 15, "Fred", "Weasley" },
                    { 29, 16, "Fred", "Weasley" },
                    { 30, 18, "Fred", "Weasley" },
                    { 31, 19, "Fred", "Weasley" },
                    { 32, 20, "Fred", "Weasley" },
                    { 33, 2, "Percival", "Weasley" },
                    { 34, 15, "Percival", "Weasley" },
                    { 35, 16, "Percival", "Weasley" },
                    { 36, 17, "Percival", "Weasley" },
                    { 37, 19, "Percival", "Weasley" },
                    { 38, 20, "Percival", "Weasley" },
                    { 39, 2, "Charile", "Weasley" }
                });

            migrationBuilder.InsertData(
                table: "Siblings",
                columns: new[] { "siblingID", "personIDFK", "siblingFirstName", "siblingLastName" },
                values: new object[,]
                {
                    { 40, 15, "Charile", "Weasley" },
                    { 41, 16, "Charile", "Weasley" },
                    { 42, 17, "Charile", "Weasley" },
                    { 43, 18, "Charile", "Weasley" },
                    { 44, 20, "Charile", "Weasley" },
                    { 45, 2, "Bill", "Weasley" },
                    { 46, 15, "Bill", "Weasley" },
                    { 47, 16, "Bill", "Weasley" },
                    { 48, 17, "Bill", "Weasley" },
                    { 49, 18, "Bill", "Weasley" },
                    { 50, 19, "Bill", "Weasley" },
                    { 51, 23, "Arthur", "Weasley" },
                    { 52, 14, "Bilius", "Weasley" },
                    { 53, 26, "Victoire", "Weasley" },
                    { 54, 27, "Victoire", "Weasley" },
                    { 55, 25, "Dominique", "Weasley" },
                    { 56, 27, "Dominique", "Weasley" },
                    { 57, 25, "Louis", "Weasley" },
                    { 58, 26, "Louis", "Weasley" }
                });

            migrationBuilder.InsertData(
                table: "Uncles",
                columns: new[] { "uncleID", "personIDFK", "uncleFirstName", "uncleLastName" },
                values: new object[,]
                {
                    { 1, 1, "Vernon", "Dursley" },
                    { 2, 10, "James", "Potter" },
                    { 3, 5, "Ronald", "Weasley" },
                    { 4, 6, "Ronald", "Weasley" },
                    { 5, 7, "Ronald", "Weasley" },
                    { 6, 25, "Ronald", "Weasley" },
                    { 7, 26, "Ronald", "Weasley" },
                    { 8, 27, "Ronald", "Weasley" },
                    { 9, 5, "George", "Weasley" },
                    { 10, 6, "George", "Weasley" },
                    { 11, 7, "George", "Weasley" },
                    { 12, 25, "George", "Weasley" },
                    { 13, 26, "George", "Weasley" },
                    { 14, 27, "George", "Weasley" },
                    { 15, 5, "Percival", "Weasley" },
                    { 16, 6, "Percival", "Weasley" },
                    { 17, 7, "Percival", "Weasley" },
                    { 18, 25, "Percival", "Weasley" },
                    { 19, 26, "Percival", "Weasley" },
                    { 20, 27, "Percival", "Weasley" },
                    { 21, 5, "Charlie", "Weasley" },
                    { 22, 6, "Charlie", "Weasley" },
                    { 23, 7, "Charlie", "Weasley" }
                });

            migrationBuilder.InsertData(
                table: "Uncles",
                columns: new[] { "uncleID", "personIDFK", "uncleFirstName", "uncleLastName" },
                values: new object[,]
                {
                    { 24, 25, "Charlie", "Weasley" },
                    { 25, 26, "Charlie", "Weasley" },
                    { 26, 27, "Charlie", "Weasley" },
                    { 27, 5, "Bill", "Weasley" },
                    { 28, 6, "Bill", "Weasley" },
                    { 29, 7, "Bill", "Weasley" },
                    { 30, 25, "Harry", "Potter" },
                    { 31, 26, "Harry", "Potter" },
                    { 32, 27, "Harry", "Potter" },
                    { 33, 2, "Bilius", "Weasley" },
                    { 34, 15, "Bilius", "Weasley" },
                    { 35, 16, "Bilius", "Weasley" },
                    { 36, 17, "Bilius", "Weasley" },
                    { 37, 18, "Bilius", "Weasley" },
                    { 38, 19, "Bilius", "Weasley" },
                    { 39, 20, "Bilius", "Weasley" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "addressID", "BirthDate", "DethDate", "city", "country", "personIDFK" },
                values: new object[,]
                {
                    { 1, 1980, 0, "Godric's Hollow", "Great Britain", 1 },
                    { 2, 1981, 0, "", "Great Britain", 2 },
                    { 3, 1960, 1981, "Godric's Hollow", "Great Britain", 3 },
                    { 4, 1960, 1981, "Godric's Hollow", "Great Britain", 4 },
                    { 5, 0, 0, "Godric's Hollow", "Great Britain", 5 },
                    { 6, 2006, 0, "Godric's Hollow", "Great Britain", 6 },
                    { 7, 1980, 0, "Godric's Hollow", "Great Britain", 7 },
                    { 8, 1958, 0, "", "Great Britain", 8 },
                    { 9, 1954, 0, "Godric's Hollow", "Great Britain", 9 },
                    { 10, 1980, 0, "", "Great Britain", 10 },
                    { 11, 0, 1979, "", "Great Britain", 11 },
                    { 12, 1909, 1978, "", "Great Britain", 12 },
                    { 13, 1951, 0, "", "Great Britain", 13 },
                    { 14, 1950, 0, "", "Great Britain", 14 },
                    { 15, 1980, 0, "", "Great Britain", 15 },
                    { 16, 1978, 0, "", "Great Britain", 16 },
                    { 17, 1978, 1997, "", "Great Britain", 17 },
                    { 18, 1976, 0, "", "Great Britain", 18 },
                    { 19, 1972, 0, "", "Great Britain", 19 },
                    { 20, 1970, 0, "", "Great Britain", 20 }
                });

            migrationBuilder.InsertData(
                table: "Fathers",
                columns: new[] { "fatherID", "fatherFirstName", "fatherLastName", "personIDFK" },
                values: new object[,]
                {
                    { 1, "Harry", "Potter", 5 },
                    { 2, "Harry", "Potter", 6 },
                    { 3, "Harry", "Potter", 7 },
                    { 4, "James", "Potter", 1 },
                    { 5, "Fleamont", "Potter", 3 },
                    { 6, "Vemon", "Dursley", 10 },
                    { 7, "Arthur", "Weasley", 2 },
                    { 8, "Arthur", "Weasley", 15 },
                    { 9, "Arthur", "Weasley", 16 },
                    { 10, "Arthur", "Weasley", 17 },
                    { 11, "Arthur", "Weasley", 18 },
                    { 12, "Arthur", "Weasley", 19 },
                    { 13, "Arthur", "Weasley", 20 },
                    { 14, "Bill", "Weasley", 25 },
                    { 15, "Bill", "Weasley", 26 },
                    { 16, "Bill", "Weasley", 27 },
                    { 17, "Septimus", "Weasley", 14 }
                });

            migrationBuilder.InsertData(
                table: "Mothers",
                columns: new[] { "motherID", "motherFirstName", "motherLastName", "personIDFK" },
                values: new object[,]
                {
                    { 1, "Ginevra", "Weasley", 5 },
                    { 2, "Ginevra", "Weasley", 6 },
                    { 3, "Ginevra", "Weasley", 7 },
                    { 4, "Lily", "Potter", 1 },
                    { 5, "Petunia", "Evans", 10 }
                });

            migrationBuilder.InsertData(
                table: "Mothers",
                columns: new[] { "motherID", "motherFirstName", "motherLastName", "personIDFK" },
                values: new object[,]
                {
                    { 6, "Euphemia", "", 11 },
                    { 7, "Molly", "Prewett", 2 },
                    { 8, "Molly", "Prewett", 15 },
                    { 9, "Molly", "Prewett", 16 },
                    { 10, "Molly", "Prewett", 17 },
                    { 11, "Molly", "Prewett", 18 },
                    { 12, "Molly", "Prewett", 19 },
                    { 13, "Molly", "Prewett", 20 },
                    { 14, "Fleur", "Delacour", 25 },
                    { 15, "Fleur", "Delacour", 26 },
                    { 16, "Fleur", "Delacour", 27 }
                });

            migrationBuilder.InsertData(
                table: "Spouses",
                columns: new[] { "spouseID", "personIDFK", "spouseFirstName", "spouseLastName" },
                values: new object[,]
                {
                    { 1, 2, "Harry", "Potter" },
                    { 2, 1, "Ginevra", "Weasley" },
                    { 3, 4, "James", "Potter" },
                    { 4, 3, "Lily", "Evans" },
                    { 5, 9, "Petunia", "Evans" },
                    { 6, 8, "Vernon", "Dursley" },
                    { 7, 12, "Euphemia", "" },
                    { 8, 11, "Fleamont", "Potter" },
                    { 9, 14, "Molly", "Prewett" },
                    { 10, 13, "Arthur", "Weasley" },
                    { 11, 22, "Septimus", "Weasley" },
                    { 12, 21, "Cedrella", "Black" },
                    { 13, 24, "bill", "Weasley" },
                    { 14, 20, "Fleur", "Delacour" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_personIDFK",
                table: "Addresses",
                column: "personIDFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_auntperson_personIDFK",
                table: "auntperson",
                column: "personIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_childrenperson_personIDFK",
                table: "childrenperson",
                column: "personIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_cousinperson_personIDFK",
                table: "cousinperson",
                column: "personIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Fathers_personIDFK",
                table: "Fathers",
                column: "personIDFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_grandFatherperson_personIDFK",
                table: "grandFatherperson",
                column: "personIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_grandMotherperson_personIDFK",
                table: "grandMotherperson",
                column: "personIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Mothers_personIDFK",
                table: "Mothers",
                column: "personIDFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personsibling_personIDFK",
                table: "personsibling",
                column: "personIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_personuncle_personIDFK",
                table: "personuncle",
                column: "personIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Spouses_personIDFK",
                table: "Spouses",
                column: "personIDFK",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "auntperson");

            migrationBuilder.DropTable(
                name: "childrenperson");

            migrationBuilder.DropTable(
                name: "cousinperson");

            migrationBuilder.DropTable(
                name: "Fathers");

            migrationBuilder.DropTable(
                name: "grandFatherperson");

            migrationBuilder.DropTable(
                name: "grandMotherperson");

            migrationBuilder.DropTable(
                name: "Mothers");

            migrationBuilder.DropTable(
                name: "personsibling");

            migrationBuilder.DropTable(
                name: "personuncle");

            migrationBuilder.DropTable(
                name: "Spouses");

            migrationBuilder.DropTable(
                name: "Aunts");

            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "Cousins");

            migrationBuilder.DropTable(
                name: "GrandFathers");

            migrationBuilder.DropTable(
                name: "GrandMothers");

            migrationBuilder.DropTable(
                name: "Siblings");

            migrationBuilder.DropTable(
                name: "Uncles");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
