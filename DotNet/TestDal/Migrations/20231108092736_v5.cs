using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDal.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RelatedToOne",
                table: "ToOnes");

            migrationBuilder.AddColumn<int>(
                name: "RelatedToOneId",
                table: "ToOnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ToOnes_RelatedToOneId",
                table: "ToOnes",
                column: "RelatedToOneId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToOnes_Ones_RelatedToOneId",
                table: "ToOnes",
                column: "RelatedToOneId",
                principalTable: "Ones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToOnes_Ones_RelatedToOneId",
                table: "ToOnes");

            migrationBuilder.DropIndex(
                name: "IX_ToOnes_RelatedToOneId",
                table: "ToOnes");

            migrationBuilder.DropColumn(
                name: "RelatedToOneId",
                table: "ToOnes");

            migrationBuilder.AddColumn<string>(
                name: "RelatedToOne",
                table: "ToOnes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
