using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61b6e92d-372d-4adc-9dfa-bab52621726e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63f2b40c-50dd-46dc-8748-5261c2165b9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2ef5891-fd82-45c9-a605-e647534efb33");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "086a6a8f-ae9e-437a-9d27-efe4234343f6", "2396fb39-ba31-4d69-b327-0584bac87ca8", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "351f6ee0-8fe2-45a6-beba-da2f553a50dd", "98a2f6ac-dd67-4c2d-9b96-1b858937a8c1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89087a94-fcf1-4604-ac5c-82ebff50344b", "b6d64a69-f39e-4dfe-a88b-639a08c5e52a", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "086a6a8f-ae9e-437a-9d27-efe4234343f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "351f6ee0-8fe2-45a6-beba-da2f553a50dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89087a94-fcf1-4604-ac5c-82ebff50344b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61b6e92d-372d-4adc-9dfa-bab52621726e", "3c44f2bc-d90f-4428-9ea9-c51f5f926bb1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63f2b40c-50dd-46dc-8748-5261c2165b9e", "b1a0c60f-dc58-46b5-a726-1cc5c5697dca", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2ef5891-fd82-45c9-a605-e647534efb33", "d4580954-ef18-4dc1-b4bb-f6b1c6d67c0c", "Admin", "ADMIN" });
        }
    }
}
