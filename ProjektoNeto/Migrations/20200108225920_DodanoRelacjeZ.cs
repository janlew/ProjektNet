using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektoNeto.Migrations
{
    public partial class DodanoRelacjeZ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opinie_Samochody_SamochodId",
                table: "Opinie");

            migrationBuilder.AlterColumn<int>(
                name: "SamochodId",
                table: "Opinie",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Opinie_Samochody_SamochodId",
                table: "Opinie",
                column: "SamochodId",
                principalTable: "Samochody",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opinie_Samochody_SamochodId",
                table: "Opinie");

            migrationBuilder.AlterColumn<int>(
                name: "SamochodId",
                table: "Opinie",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Opinie_Samochody_SamochodId",
                table: "Opinie",
                column: "SamochodId",
                principalTable: "Samochody",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
