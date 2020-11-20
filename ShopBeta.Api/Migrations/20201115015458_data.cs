using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16da5222-ed43-4a10-a357-4b4f2b175088");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dcc012a-7dd5-47c8-83b1-31204b4c7b3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7f7b8f-126b-4385-8c93-729be75c85d4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dfb10cce-f3a6-4618-8120-d3a5d2b71e46", "888f2cf4-c777-4afa-83e4-a4c3b9b0d178", "Seller", "SELLER" },
                    { "7e76373f-50ab-4e54-813a-c6f928ec5d5d", "b0399264-a5a6-4b0a-b60c-fd78ef550d98", "Customer", "CUSTOMER" },
                    { "5b9b0c44-ffc0-49a5-83d5-60335f016035", "a14e4fec-b195-4acb-ae9a-a5fa7a7c30f7", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 15, 1, 54, 57, 621, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 15, 1, 54, 57, 621, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 15, 1, 54, 57, 621, DateTimeKind.Utc).AddTicks(1402));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b9b0c44-ffc0-49a5-83d5-60335f016035");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e76373f-50ab-4e54-813a-c6f928ec5d5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfb10cce-f3a6-4618-8120-d3a5d2b71e46");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16da5222-ed43-4a10-a357-4b4f2b175088", "cf7ab8f5-65c9-44dc-942d-b78e850960f9", "Seller", "SELLER" },
                    { "2dcc012a-7dd5-47c8-83b1-31204b4c7b3b", "00727b37-3038-4346-b434-3b934f9cb179", "Customer", "CUSTOMER" },
                    { "2e7f7b8f-126b-4385-8c93-729be75c85d4", "5a49eb61-98b2-48c4-9916-1ca8a712225f", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 15, 1, 43, 34, 359, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 15, 1, 43, 34, 359, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 15, 1, 43, 34, 359, DateTimeKind.Utc).AddTicks(8375));
        }
    }
}
