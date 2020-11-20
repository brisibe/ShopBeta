using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class ordersss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60cb18cf-1a98-422b-a225-acfabcc63be2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ff75437-378a-4d6d-b3f4-6f2480d13681");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe1bfe9f-afa6-4d6b-92a6-03f66f3d2931");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29e6cc74-582a-42f8-822e-d94b42a483dc", "cee7fd59-52b7-4f2a-92a7-1b8a391d9f15", "Seller", "SELLER" },
                    { "c92534ec-1973-4a14-b65a-da1e631486d0", "570eeccf-da24-4979-9e57-e430f6558046", "Customer", "CUSTOMER" },
                    { "925a19b4-ad6e-41a4-8bfb-7ec46f055f0f", "2111baf3-1297-4da7-ad94-21513445c967", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 19, 20, 51, 34, 12, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 19, 20, 51, 34, 13, DateTimeKind.Utc).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 19, 20, 51, 34, 13, DateTimeKind.Utc).AddTicks(2039));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29e6cc74-582a-42f8-822e-d94b42a483dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "925a19b4-ad6e-41a4-8bfb-7ec46f055f0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c92534ec-1973-4a14-b65a-da1e631486d0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ff75437-378a-4d6d-b3f4-6f2480d13681", "816b56a8-02e8-4374-98aa-a325907985b2", "Seller", "SELLER" },
                    { "60cb18cf-1a98-422b-a225-acfabcc63be2", "4621c80f-c3e7-4325-a747-3d2277596885", "Customer", "CUSTOMER" },
                    { "fe1bfe9f-afa6-4d6b-92a6-03f66f3d2931", "9b104c5a-106c-43f2-b2cc-26e69e10d57e", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 19, 13, 3, 25, 762, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 19, 13, 3, 25, 762, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 19, 13, 3, 25, 762, DateTimeKind.Utc).AddTicks(8215));
        }
    }
}
