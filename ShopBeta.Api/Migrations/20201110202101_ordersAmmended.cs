using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class ordersAmmended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd6644c-747f-4432-b84b-ea10a71b2a8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e041d9f1-9a75-446e-a352-516958d5f255");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1293093-e561-46b2-9577-cae241b426ae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9dc84326-d2b1-44e0-81ec-cb426c7aa027", "f2dcb1f6-4c24-4b91-8a88-f602d4984fec", "Seller", "SELLER" },
                    { "7a3e67ad-3316-437e-b1ed-a914c0a9f4e9", "0f4d2531-fb61-4446-8cc1-c89fe9833b59", "Customer", "CUSTOMER" },
                    { "b36da8eb-b3a6-46e7-989e-86438e0d19c4", "9fd357ef-3341-44bd-869d-6851c689b1e1", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 10, 20, 21, 0, 149, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 10, 20, 21, 0, 149, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 10, 20, 21, 0, 149, DateTimeKind.Utc).AddTicks(9190));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a3e67ad-3316-437e-b1ed-a914c0a9f4e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dc84326-d2b1-44e0-81ec-cb426c7aa027");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b36da8eb-b3a6-46e7-989e-86438e0d19c4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9cd6644c-747f-4432-b84b-ea10a71b2a8f", "a024a3e8-7668-44cf-8fd0-9d13758a2572", "Seller", "SELLER" },
                    { "e1293093-e561-46b2-9577-cae241b426ae", "03c672a9-9fac-489b-97f7-7717678eea2a", "Customer", "CUSTOMER" },
                    { "e041d9f1-9a75-446e-a352-516958d5f255", "61052091-a0e0-4fba-9267-ea011fc08098", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 10, 20, 13, 28, 873, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 10, 20, 13, 28, 873, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 10, 20, 13, 28, 873, DateTimeKind.Utc).AddTicks(3370));
        }
    }
}
