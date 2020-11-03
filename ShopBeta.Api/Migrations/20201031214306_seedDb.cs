using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class seedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "Category", "Description", "Name", "OldPrice", "Price" },
                values: new object[,]
                {
                    { 1, "Apple", "Phones", "500Gb rom, 12mp rear camera, blah blah blah", "Iphone 12", "850,000", "800,000" },
                    { 2, "Samsung", "Phones", "500Gb rom, 12mp rear camera, blah blah blah", "Samsung Galaxy s11", "650,000", "500,000" },
                    { 3, "Sony", "Gaming", "500Gb hdd,  dual controller, lah blah blah", "Playstation 5", "250,000", "200,000" },
                    { 4, "Acer", "Computer", "500Gb ROM, 8Gb RAM, Nvidia gtx 1020, core i7", "Acer Aspire E5", "420,000", "400,000" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "Name", "ProductId", "date" },
                values: new object[] { 1, "A wonderful product, swift delivery", "Bode Thomas", 1, new DateTime(2020, 10, 31, 21, 43, 5, 487, DateTimeKind.Utc).AddTicks(8396) });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "Name", "ProductId", "date" },
                values: new object[] { 2, "Great product but expensive", "Tunde Brisibe", 1, new DateTime(2020, 10, 31, 21, 43, 5, 487, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "Name", "ProductId", "date" },
                values: new object[] { 3, "wonderful laptop", "Jesse Brisibe", 4, new DateTime(2020, 10, 31, 21, 43, 5, 487, DateTimeKind.Utc).AddTicks(9902) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
