using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektoNeto.Migrations
{
    public partial class DodanieRelacji : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Wiadomosc",
                table: "Opinie",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NazwaUzytkownika",
                table: "Opinie",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Opinie",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Wiadomosc",
                table: "Opinie",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5000);

            migrationBuilder.AlterColumn<string>(
                name: "NazwaUzytkownika",
                table: "Opinie",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Opinie",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
