using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDal.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "toMany2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toMany2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManytoMany2",
                columns: table => new
                {
                    ManysId = table.Column<int>(type: "int", nullable: false),
                    toMany2sId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManytoMany2", x => new { x.ManysId, x.toMany2sId });
                    table.ForeignKey(
                        name: "FK_ManytoMany2_Manys_ManysId",
                        column: x => x.ManysId,
                        principalTable: "Manys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManytoMany2_toMany2s_toMany2sId",
                        column: x => x.toMany2sId,
                        principalTable: "toMany2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManytoMany2_toMany2sId",
                table: "ManytoMany2",
                column: "toMany2sId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManytoMany2");

            migrationBuilder.DropTable(
                name: "Manys");

            migrationBuilder.DropTable(
                name: "toMany2s");
        }
    }
}
