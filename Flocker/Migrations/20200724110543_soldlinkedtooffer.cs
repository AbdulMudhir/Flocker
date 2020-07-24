using Microsoft.EntityFrameworkCore.Migrations;

namespace Flocker.Migrations
{
    public partial class soldlinkedtooffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sold_AspNetUsers_UserId",
                table: "Sold");

            migrationBuilder.DropIndex(
                name: "IX_Sold_UserId",
                table: "Sold");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Sold");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Sold");

            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "Sold",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sold_OfferId",
                table: "Sold",
                column: "OfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sold_Offers_OfferId",
                table: "Sold",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "OfferId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sold_Offers_OfferId",
                table: "Sold");

            migrationBuilder.DropIndex(
                name: "IX_Sold_OfferId",
                table: "Sold");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "Sold");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Sold",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Sold",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sold_UserId",
                table: "Sold",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sold_AspNetUsers_UserId",
                table: "Sold",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
