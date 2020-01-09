using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektoNeto.Migrations
{
    public partial class Test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Opinie");

            migrationBuilder.AddColumn<bool>(
                name: "Test",
                table: "Samochody",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Samochody");

            migrationBuilder.AddColumn<bool>(
                name: "Test",
                table: "Opinie",
                nullable: false,
                defaultValue: false);
        }
    }
}
