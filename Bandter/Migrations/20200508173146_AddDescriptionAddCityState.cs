using Microsoft.EntityFrameworkCore.Migrations;

namespace Bandter.Migrations
{
    public partial class AddDescriptionAddCityState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Events");
        }
    }
}
