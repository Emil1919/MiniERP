using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ShippingAdresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Invoices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ShippingAdresses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3295dff-ace0-442c-8cd1-daf20993d9ff", "AQAAAAEAACcQAAAAEOCHk82BU15ASC/RC2wf/H9Jk6zFxjkCiVBgZy3lJM7nGtP1HTxwFXxowzoecLRB+A==", "a22562aa-ea0a-4581-8abf-6762809610af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ca8674f-fe60-4b83-837b-52b7d35278c9", "AQAAAAEAACcQAAAAEDo7CGflHbU/jQn25BpYrJhV03LTCHq06JbigG+i4JksEEiHcWczDEab0axAq3IEqA==", "06b8cead-f4a8-43c8-afb6-2a470900abc4" });

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
    }
}
