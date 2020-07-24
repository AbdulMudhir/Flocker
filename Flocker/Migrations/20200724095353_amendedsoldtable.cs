using Microsoft.EntityFrameworkCore.Migrations;

namespace Flocker.Migrations
{
    public partial class amendedsoldtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sold_SoldId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SoldId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SoldId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SoldId1",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Sold_ProductId",
                table: "Sold",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sold_Products_ProductId",
                table: "Sold",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sold_Products_ProductId",
                table: "Sold");

            migrationBuilder.DropIndex(
                name: "IX_Sold_ProductId",
                table: "Sold");

            migrationBuilder.AddColumn<int>(
                name: "SoldId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoldId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SoldId1",
                table: "Products",
                column: "SoldId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sold_SoldId1",
                table: "Products",
                column: "SoldId1",
                principalTable: "Sold",
                principalColumn: "SoldId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
