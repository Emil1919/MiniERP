using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Data.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "358767d8-7a59-4524-9b2a-d5626113b963", "AQAAAAEAACcQAAAAEN2A5Krra5V0NGrOji+iijvRCFMSSTXDuo6DLttmQAS9jHFSjUgG1tkGz9PY63M/Iw==", "30f916f2-7090-4dc8-b484-fbe76b44f2ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af8c69f7-50c4-4b56-bc5b-82315781363b", "AQAAAAEAACcQAAAAEJWwl1xQJxYskmez+AbNvqYy5vSkaKXUQZIW8dgZP7doYqsUYaHfsWuZwxIY10uWqQ==", "a2b63078-a0f0-4be3-87fb-a6ea478fdebc" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompanyName",
                value: "GS Group 2000 LTD");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 12, 15, 39, 13, 494, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 13, 15, 39, 13, 494, DateTimeKind.Local).AddTicks(2687));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15e0a2d2-e2aa-4cce-9860-dc7b74cbed98", "AQAAAAEAACcQAAAAEDFlmSIhoYt2dUz4PqrclUWHhPs7XOwob86KFhJxOUjUThX8Hem/Fjp0DCxvsJCrQQ==", "6ede4ce5-a3e2-4c17-a34d-6ca1632e8dcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4bce6da-2b00-4764-9362-991d00be8a3f", "AQAAAAEAACcQAAAAELdBGScA8YrKTHWuCTA+uOtju+T8psO0U3fa7Qu0wtuUZe2u50YGCRsObV72d8N0LQ==", "52a8ddbc-3c98-453d-967e-c2acff86f7df" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CompanyName",
                value: "MiniERP");

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 12, 13, 35, 23, 202, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 13, 13, 35, 23, 202, DateTimeKind.Local).AddTicks(1749));
        }
    }
}
