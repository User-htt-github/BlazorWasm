using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor.API.Migrations
{
    /// <inheritdoc />
    public partial class seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7b800169-d32a-4461-8b78-10480168389c"), 0, "5d38d72f-ddf2-496b-99cf-c99839e205d2", "hungttworking@gmail.com", false, "People", "Anon", false, null, null, null, "AQAAAAEAACcQAAAAEJizXwXLrQItK1kYL/53KMGX7OrG4hHVMh0WbzSWjRATom6x3Kw8FiPSIMotz5s/MA==", "1234567890", false, null, false, "admin" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AssigneeId", "CreatedDate", "Name", "Priority", "Status" },
                values: new object[] { new Guid("2105a445-c2de-4e3a-8b68-9e3a9e4ea026"), new Guid("7b800169-d32a-4461-8b78-10480168389c"), new DateTime(2023, 12, 13, 16, 45, 26, 679, DateTimeKind.Local).AddTicks(2944), "Task 1", 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("2105a445-c2de-4e3a-8b68-9e3a9e4ea026"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7b800169-d32a-4461-8b78-10480168389c"));
        }
    }
}
