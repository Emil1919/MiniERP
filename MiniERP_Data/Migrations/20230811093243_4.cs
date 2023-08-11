using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13cd3a24-69af-4551-ad3f-3de170590ce3", "AQAAAAEAACcQAAAAEFbOnhABaqtar94i9la7DCB5IO8YpDMXrPNH8weaNRBaTDeNUPKnykLYvShKPJDibQ==", "ed37a540-519d-4278-a3db-13a00c0c2ff8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8368990-cf13-4944-bdef-9af6f73292b5", "AQAAAAEAACcQAAAAEEVTjedr1b2fdO11RpX7p2dXcHp4aWIAFTQUn/XpzodgY5LKT2fIALk2LFiRLzNeEw==", "6d6d63e7-851a-4dae-bd6f-2c916bfd1479" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 11, 12, 32, 42, 476, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 12, 12, 32, 42, 476, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c0002a3-6186-4dad-a8bf-b418d15b10dd", "AQAAAAEAACcQAAAAEMCGq5wxGkIqmbkoW37xXtogzLqnDUIa6vbyA+FKVWcQllek0HmFQc3RfFy3xhou6g==", "755842bf-be71-4e63-a36f-546ee4a4e0f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5582d3b-fb03-48fd-b65f-987947e7c04e", "AQAAAAEAACcQAAAAEKUfG8x8uPgstH7G6DcHxHhb2+IdsBeDK3r7J9rabXXpnIqqPI3sLpUVTCPIRsccDg==", "d66a9cd8-ecea-456d-ae56-3d6a985b517c" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 10, 15, 31, 0, 645, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 11, 15, 31, 0, 645, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
