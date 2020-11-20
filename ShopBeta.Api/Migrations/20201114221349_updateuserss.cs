using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class updateuserss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "628fecff-a6bc-44c2-be4a-f39cd5a00926");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cf8ba8d-a2b6-4278-b2df-7338e9366df1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aef799f2-65d9-4a46-ba3c-e443b72bb86d");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ff9cbb9-9503-485a-97dd-03bc2603bf3e", "31fc6645-d20e-4da0-b652-c6a8afad740b", "Seller", "SELLER" },
                    { "4d6e8e23-1ca7-4f93-90a0-f77d0cb32e17", "36df4a46-39a8-4b80-8d4b-9e75bd07056a", "Customer", "CUSTOMER" },
                    { "2407c608-e0e2-4c54-94e1-c603a0a33bb8", "865c5e3f-2567-46f7-aa9c-fc8482aeaacb", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 14, 22, 13, 48, 179, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 14, 22, 13, 48, 179, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 14, 22, 13, 48, 179, DateTimeKind.Utc).AddTicks(6116));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2407c608-e0e2-4c54-94e1-c603a0a33bb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d6e8e23-1ca7-4f93-90a0-f77d0cb32e17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ff9cbb9-9503-485a-97dd-03bc2603bf3e");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "628fecff-a6bc-44c2-be4a-f39cd5a00926", "5a8663a3-66d6-430f-bd86-2dd68e52ba61", "Seller", "SELLER" },
                    { "9cf8ba8d-a2b6-4278-b2df-7338e9366df1", "5f12d4c4-16bf-4e75-9aa8-d204f8c4e932", "Customer", "CUSTOMER" },
                    { "aef799f2-65d9-4a46-ba3c-e443b72bb86d", "ee79a5c0-ffa3-43b7-aba8-1469afe68261", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 14, 21, 38, 42, 814, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 14, 21, 38, 42, 814, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 14, 21, 38, 42, 814, DateTimeKind.Utc).AddTicks(3402));
        }
    }
}
