using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Data.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasInvoice",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ce09ff9-2be4-478b-a8bf-89ec13f9cee2", "AQAAAAEAACcQAAAAEFlT0MTa9HkpExoWfLVxgAIPVcPmwVE/Y05rWjuRUf3CC8U2xDLJ01uf+/m7iz+8XQ==", "7b627c23-48e8-42a7-b161-7a0cbe24e384" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dea5201-dd39-41bf-b6a6-ef18b067ba65", "AQAAAAEAACcQAAAAEPZl4HT6N/wPIkEfwY6PZvXjrjPcDf/t4r4S/swyyDf+sV7w2GcxBBeI7obn4g+HJg==", "75bfe3bd-2bd0-4108-b648-e03dfb3e0cf2" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 11, 16, 43, 50, 693, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfInvoice",
                value: new DateTime(2023, 8, 12, 16, 43, 50, 693, DateTimeKind.Local).AddTicks(5682));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasInvoice",
                table: "Orders");

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
        }
    }
}
