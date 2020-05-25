using Microsoft.EntityFrameworkCore.Migrations;

namespace Bandter.Migrations
{
    public partial class AddRSVP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Going",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Going",
                table: "Events");
        }
    }
}
