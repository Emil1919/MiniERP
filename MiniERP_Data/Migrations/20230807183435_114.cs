using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Data.Migrations
{
    public partial class _114 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShippingsAdresses_Customers_CustomerId",
                table: "ShippingsAdresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingsAdresses",
                table: "ShippingsAdresses");

            migrationBuilder.RenameTable(
                name: "ShippingsAdresses",
                newName: "ShippingAdresses");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingsAdresses_CustomerId",
                table: "ShippingAdresses",
                newName: "IX_ShippingAdresses_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingAdresses",
                table: "ShippingAdresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingAdresses_Customers_CustomerId",
                table: "ShippingAdresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShippingAdresses_Customers_CustomerId",
                table: "ShippingAdresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingAdresses",
                table: "ShippingAdresses");

            migrationBuilder.RenameTable(
                name: "ShippingAdresses",
                newName: "ShippingsAdresses");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingAdresses_CustomerId",
                table: "ShippingsAdresses",
                newName: "IX_ShippingsAdresses_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingsAdresses",
                table: "ShippingsAdresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingsAdresses_Customers_CustomerId",
                table: "ShippingsAdresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
