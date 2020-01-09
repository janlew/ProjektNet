using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektoNeto.Migrations
{
    public partial class Nowa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OczekujeOdpowiedzi",
                table: "Opinie");

            migrationBuilder.AlterColumn<string>(
                name: "NazwaUzytkownika",
                table: "Opinie",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Opinie",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NazwaUzytkownika",
                table: "Opinie",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Opinie",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OczekujeOdpowiedzi",
                table: "Opinie",
                nullable: false,
                defaultValue: false);
        }
    }
}
