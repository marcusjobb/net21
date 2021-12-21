using Microsoft.EntityFrameworkCore.Migrations;

namespace Genealogy_Tree.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monarchies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monarchies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonarchyMembers",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<int>(type: "int", nullable: false),
                    DeathDate = table.Column<int>(type: "int", nullable: false),
                    MonarchyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonarchyMembers", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_MonarchyMembers_Monarchies_MonarchyId",
                        column: x => x.MonarchyId,
                        principalTable: "Monarchies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonarchyMemberMonarchyMember",
                columns: table => new
                {
                    ChildrenPersonID = table.Column<int>(type: "int", nullable: false),
                    ParentsPersonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonarchyMemberMonarchyMember", x => new { x.ChildrenPersonID, x.ParentsPersonID });
                    table.ForeignKey(
                        name: "FK_MonarchyMemberMonarchyMember_MonarchyMembers_ChildrenPersonID",
                        column: x => x.ChildrenPersonID,
                        principalTable: "MonarchyMembers",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonarchyMemberMonarchyMember_MonarchyMembers_ParentsPersonID",
                        column: x => x.ParentsPersonID,
                        principalTable: "MonarchyMembers",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonarchyMemberMonarchyMember_ParentsPersonID",
                table: "MonarchyMemberMonarchyMember",
                column: "ParentsPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_MonarchyMembers_MonarchyId",
                table: "MonarchyMembers",
                column: "MonarchyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonarchyMemberMonarchyMember");

            migrationBuilder.DropTable(
                name: "MonarchyMembers");

            migrationBuilder.DropTable(
                name: "Monarchies");
        }
    }
}
