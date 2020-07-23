using Microsoft.EntityFrameworkCore.Migrations;

namespace Flocker.Migrations
{
    public partial class offerpending : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isPending",
                table: "Offers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isPending",
                table: "Offers");
        }
    }
}
