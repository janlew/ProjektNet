using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektoNeto.Migrations
{
    public partial class SamochodZmiana : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "JestWCentrali",
                table: "Samochody",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JestWCentrali",
                table: "Samochody");
        }
    }
}
