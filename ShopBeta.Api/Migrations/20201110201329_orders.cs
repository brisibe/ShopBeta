using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBeta.Api.Migrations
{
    public partial class orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "797e2c51-8918-4f98-a6d8-e7b48658ce7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c36e13b-e006-46a9-ac9c-15ebf5b8a35c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd8f23dd-f275-42a2-a156-3e4b32fe40e0");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "bd8f23dd-f275-42a2-a156-3e4b32fe40e0", "c6f8398f-9a48-449f-ace5-aad20af3726e", "Seller", "SELLER" },
                    { "797e2c51-8918-4f98-a6d8-e7b48658ce7a", "9d749a80-4198-4f35-81f9-7f90f164d2c9", "Customer", "CUSTOMER" },
                    { "8c36e13b-e006-46a9-ac9c-15ebf5b8a35c", "67bb62cb-c975-46cb-99bd-bf120147e6c4", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "date",
                value: new DateTime(2020, 11, 9, 2, 31, 23, 86, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "date",
                value: new DateTime(2020, 11, 9, 2, 31, 23, 86, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "date",
                value: new DateTime(2020, 11, 9, 2, 31, 23, 86, DateTimeKind.Utc).AddTicks(8175));
        }
    }
}
