using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Data.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6efda9b5-ff75-493c-bc59-001288798417", "AQAAAAEAACcQAAAAENvLShPlXYz/x4HcchPEcgfpuY2XUTnmc8+jzAM0fnx/j2mZtPkGMWIXFAo5cKBXew==", "44e09cdc-f800-4575-918e-976a77f7dc38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fc221db-1900-4b27-acdd-44901bf0307a", "AQAAAAEAACcQAAAAECsyxU+fUAUh+RAU2B4LvFjumwAhcpohuz3UadLyZoYDj0hpwWpLCNWa8lI6BTh3fw==", "747e3ffb-7b57-47d8-a7e5-8d3076ef22d1" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 12, 13, 32, 50, 144, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 13, 13, 32, 50, 144, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb6773e6-5d94-4df2-9430-7f33b59e6c3c", "AQAAAAEAACcQAAAAEO+1IaElsI+PH3H4lBY3mE/ssdsIe9cLIQptCkB1fu/vBUoarzxgbjH8v2ZyH7xvfQ==", "512bfd91-0be3-4d83-8091-9831bd59d8f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "398f4289-250b-4373-8b87-135e437ae1d8", "AQAAAAEAACcQAAAAELOAbH/JT+RguvEKImlCemZzZSY6FKaZWP0cwvwZndRkenWNRCJNwZiIGAFo2OBtRw==", "14735268-2dcf-406d-b166-f30568079ad7" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 11, 17, 20, 37, 117, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 12, 17, 20, 37, 117, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
