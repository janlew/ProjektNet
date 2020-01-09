using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektoNeto.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opinie_Samochody_SamochodId",
                table: "Opinie");

            migrationBuilder.DropIndex(
                name: "IX_Opinie_SamochodId",
                table: "Opinie");

            migrationBuilder.DropColumn(
                name: "SamochodId",
                table: "Opinie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SamochodId",
                table: "Opinie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Opinie_SamochodId",
                table: "Opinie",
                column: "SamochodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Opinie_Samochody_SamochodId",
                table: "Opinie",
                column: "SamochodId",
                principalTable: "Samochody",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
