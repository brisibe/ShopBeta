using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class dataa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Store",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71e5a491-3609-4dae-a861-27cfe2537d79", "e1041886-9eda-454e-8709-f9ddbb62bcf2", "Seller", "SELLER" },
                    { "74c6b377-4945-4e83-a2dc-a4e01dce3419", "f5333cd5-bc0b-41cb-b95d-dd76a539170d", "Customer", "CUSTOMER" },
                    { "89f6446b-c279-46a1-99ed-cb51b6b46d40", "c6f46bbb-b5cb-4d0d-bc45-3095d3b2b3f3", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 15, 1, 57, 46, 444, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 15, 1, 57, 46, 444, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 15, 1, 57, 46, 444, DateTimeKind.Utc).AddTicks(4510));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71e5a491-3609-4dae-a861-27cfe2537d79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74c6b377-4945-4e83-a2dc-a4e01dce3419");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89f6446b-c279-46a1-99ed-cb51b6b46d40");

            migrationBuilder.DropColumn(
                name: "Store",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
