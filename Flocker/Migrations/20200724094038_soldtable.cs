using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flocker.Migrations
{
    public partial class soldtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sold",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Sold",
                columns: table => new
                {
                    SoldId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    IsSold = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    DateSold = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sold", x => x.SoldId);
                    table.ForeignKey(
                        name: "FK_Sold_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sold_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sold_ProductId",
                table: "Sold",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sold_UserId",
                table: "Sold",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sold");

            migrationBuilder.AddColumn<bool>(
                name: "Sold",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
