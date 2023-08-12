using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Data.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
