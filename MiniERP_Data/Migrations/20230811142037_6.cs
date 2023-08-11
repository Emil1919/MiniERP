using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Data.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Companies",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Companies");

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
    }
}
