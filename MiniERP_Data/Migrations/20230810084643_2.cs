using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "d3295dff-ace0-442c-8cd1-daf20993d9ff", "admin@gmail.com", false, false, null, "admin@gmail.com", "ADMIN", "AQAAAAEAACcQAAAAEOCHk82BU15ASC/RC2wf/H9Jk6zFxjkCiVBgZy3lJM7nGtP1HTxwFXxowzoecLRB+A==", null, false, "a22562aa-ea0a-4581-8abf-6762809610af", false, "admin" },
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f", 0, "0ca8674f-fe60-4b83-837b-52b7d35278c9", "user@gmail.com", false, false, null, "user@gmail.com", "USER", "AQAAAAEAACcQAAAAEDo7CGflHbU/jQn25BpYrJhV03LTCHq06JbigG+i4JksEEiHcWczDEab0axAq3IEqA==", null, false, "06b8cead-f4a8-43c8-afb6-2a470900abc4", false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 10, 11, 46, 43, 17, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 11, 11, 46, 43, 17, DateTimeKind.Local).AddTicks(718));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 10, 10, 17, 33, 314, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 11, 10, 17, 33, 314, DateTimeKind.Local).AddTicks(8383));
        }
    }
}
