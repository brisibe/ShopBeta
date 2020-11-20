using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class updateproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "582e3359-3502-43cf-9d77-f0d97704f41c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8927551d-d5a0-486b-af3e-d64d4374ec77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c486ee09-98ea-4a8f-b142-96d06c873468");

            migrationBuilder.AddColumn<string>(
                name: "SellerId",
                table: "Products",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67ed8f4e-7daf-4223-8144-838d785493f2", "5c1e14b7-02aa-4feb-b48d-4cc378d3cc41", "Seller", "SELLER" },
                    { "11d057e4-81ff-4f69-9515-538495462aff", "3595422b-2099-4bba-89f3-05bdfd6885c8", "Customer", "CUSTOMER" },
                    { "006ab617-0aaf-4f35-be45-5477bce6dfb8", "10341f11-e5cf-4f11-9bcf-e80053da7f4a", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 15, 11, 27, 41, 482, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 15, 11, 27, 41, 482, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 15, 11, 27, 41, 482, DateTimeKind.Utc).AddTicks(9621));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "006ab617-0aaf-4f35-be45-5477bce6dfb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11d057e4-81ff-4f69-9515-538495462aff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67ed8f4e-7daf-4223-8144-838d785493f2");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8927551d-d5a0-486b-af3e-d64d4374ec77", "bfd02b1a-108d-40c7-8aad-bad1dae965b4", "Seller", "SELLER" },
                    { "c486ee09-98ea-4a8f-b142-96d06c873468", "bc83c559-9441-4e38-a02e-1eec364d5a5a", "Customer", "CUSTOMER" },
                    { "582e3359-3502-43cf-9d77-f0d97704f41c", "ac43d033-c85e-48a1-8f24-1a0cc6139dc3", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 15, 2, 47, 57, 760, DateTimeKind.Utc).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 15, 2, 47, 57, 760, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 15, 2, 47, 57, 760, DateTimeKind.Utc).AddTicks(5202));
        }
    }
}
