using Microsoft.EntityFrameworkCore.Migrations;

namespace Problem_Box.Data.Migrations
{
    public partial class addtableasdetailsProblems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "problems",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    complainName = table.Column<string>(nullable: false),
                    problemDuration = table.Column<string>(nullable: false),
                    problemDescription = table.Column<string>(nullable: false),
                    image = table.Column<string>(nullable: true),
                    isAvailable = table.Column<bool>(nullable: false),
                    problemCatagoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_problems", x => x.id);
                    table.ForeignKey(
                        name: "FK_problems_problemCatagories_problemCatagoryId",
                        column: x => x.problemCatagoryId,
                        principalTable: "problemCatagories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_problems_problemCatagoryId",
                table: "problems",
                column: "problemCatagoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "problems");
        }
    }
}
