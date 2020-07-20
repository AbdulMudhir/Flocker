using Microsoft.EntityFrameworkCore.Migrations;

namespace Flocker.Migrations
{
    public partial class removedlocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Location_LocationId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Products_LocationId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_LocationId",
                table: "Products",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Location_LocationId",
                table: "Products",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
