using Microsoft.EntityFrameworkCore.Migrations;

namespace Bandter.Migrations
{
    public partial class AddEventZip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "Events");
        }
    }
}
