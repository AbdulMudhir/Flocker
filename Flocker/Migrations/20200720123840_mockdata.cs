using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flocker.Migrations
{
    public partial class mockdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "~/Image/game-console.png", "Games" },
                    { 2, "~/Image/game-console.png", "Electronic" },
                    { 3, "~/Image/game-console.png", "Accessories" },
                    { 4, "~/Image/game-console.png", "Phone" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Image", "Location", "Username" },
                values: new object[,]
                {
                    { 1, "https://a.wattpad.com/cover/148493833-288-k395634.jpg", null, "Test Dummy" },
                    { 2, "https://a.wattpad.com/cover/148493833-288-k395634.jpg", null, "Bob Marley" },
                    { 3, "https://a.wattpad.com/cover/148493833-288-k395634.jpg", null, "Jack Danny" },
                    { 4, "https://a.wattpad.com/cover/148493833-288-k395634.jpg", null, "Easter Egg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "DatePosted", "Description", "Image", "Name", "Price", "Sold", "Spotlight", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for", "https://i.imgur.com/w305JQE.png", "XBOX ONE CONTROLLER", 34.99m, false, false, 1 },
                    { 2, 1, new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for", "~/Image/controller.png", "XBOX ONE CONTROLLER FREE", 34.99m, false, true, 1 },
                    { 3, 1, new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for", "~/Image/cupboard.png", "CUPBOARD", 34.99m, false, true, 2 },
                    { 4, 2, new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for", "~/Image/bed.png", "BED SHEET", 34.99m, true, false, 2 },
                    { 5, 3, new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for", "~/Image/games.png", "XBOX ONE GAMES", 7200.99m, true, false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "ProductId", "UserId", "content" },
                values: new object[,]
                {
                    { 1, 1, 1, null },
                    { 2, 1, 1, null },
                    { 3, 1, 1, null },
                    { 4, 1, 1, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
