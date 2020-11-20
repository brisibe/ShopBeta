using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class updateusersss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Shop",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                table: "AspNetUsers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Shop",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
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
    }
}
