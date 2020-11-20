using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class newData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Store",
                table: "Products",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b125f1a8-cf41-4de9-a833-8d95c5ba0e66", "d8bebe42-59c7-495a-b180-1ecb12366eff", "Seller", "SELLER" },
                    { "5c0e86e2-4de3-499c-bdec-8a0deef53b53", "c385d576-0529-43ee-88f3-3eec73b2e37d", "Customer", "CUSTOMER" },
                    { "bffbf737-23de-4df4-b534-4fae299a6b4f", "9ab5f99d-6471-4204-a5b7-eaaababfa719", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 15, 2, 42, 39, 79, DateTimeKind.Utc).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 15, 2, 42, 39, 79, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 15, 2, 42, 39, 79, DateTimeKind.Utc).AddTicks(6404));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c0e86e2-4de3-499c-bdec-8a0deef53b53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b125f1a8-cf41-4de9-a833-8d95c5ba0e66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bffbf737-23de-4df4-b534-4fae299a6b4f");

            migrationBuilder.DropColumn(
                name: "Store",
                table: "Products");

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
    }
}
