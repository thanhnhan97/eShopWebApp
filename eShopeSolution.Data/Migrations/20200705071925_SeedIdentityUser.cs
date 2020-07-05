using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopeSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("613beb9c-bb67-4f37-8435-fa7375c7db8f"), "76ff1c02-8d98-49ea-ac2e-361f1731e66b", "role admin", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("d76376ae-c59c-4853-a8ba-1bff6846ad20"), new Guid("613beb9c-bb67-4f37-8435-fa7375c7db8f") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateTime", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d76376ae-c59c-4853-a8ba-1bff6846ad20"), 0, "cafbe971-44b6-409c-b71d-14554caf975d", new DateTime(2020, 7, 5, 14, 19, 24, 429, DateTimeKind.Local).AddTicks(5159), "nhanhanhan@yahoo.com", true, "Nhan", "Thanh", false, null, "nhanhanhan@yahoo.com", "admin", "AQAAAAEAACcQAAAAEOEQGXfH67MgXWQ3Y3uxZsowfuWif61eWvKRAQTbuewZYpFFusNDdl7qTX+bh05Fcg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 5, 14, 19, 24, 399, DateTimeKind.Local).AddTicks(5238));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("613beb9c-bb67-4f37-8435-fa7375c7db8f"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("d76376ae-c59c-4853-a8ba-1bff6846ad20"), new Guid("613beb9c-bb67-4f37-8435-fa7375c7db8f") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d76376ae-c59c-4853-a8ba-1bff6846ad20"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 5, 4, 10, 55, 505, DateTimeKind.Local).AddTicks(2973));
        }
    }
}
