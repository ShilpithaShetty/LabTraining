using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDal.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ToMany1Id",
                table: "Ones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "toMany1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toMany1s", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ones_ToMany1Id",
                table: "Ones",
                column: "ToMany1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ones_toMany1s_ToMany1Id",
                table: "Ones",
                column: "ToMany1Id",
                principalTable: "toMany1s",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ones_toMany1s_ToMany1Id",
                table: "Ones");

            migrationBuilder.DropTable(
                name: "toMany1s");

            migrationBuilder.DropIndex(
                name: "IX_Ones_ToMany1Id",
                table: "Ones");

            migrationBuilder.DropColumn(
                name: "ToMany1Id",
                table: "Ones");
        }
    }
}
