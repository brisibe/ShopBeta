using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class newDataa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
