using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniERP.Data.Migrations
{
    public partial class _112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shippings",
                table: "Shippings");

            migrationBuilder.RenameTable(
                name: "Shippings",
                newName: "ShippingsAdresses");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "ShippingsAdresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingsAdresses",
                table: "ShippingsAdresses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingsAdresses_CustomerId",
                table: "ShippingsAdresses",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingsAdresses_Customers_CustomerId",
                table: "ShippingsAdresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShippingsAdresses_Customers_CustomerId",
                table: "ShippingsAdresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingsAdresses",
                table: "ShippingsAdresses");

            migrationBuilder.DropIndex(
                name: "IX_ShippingsAdresses_CustomerId",
                table: "ShippingsAdresses");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ShippingsAdresses");

            migrationBuilder.RenameTable(
                name: "ShippingsAdresses",
                newName: "Shippings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shippings",
                table: "Shippings",
                column: "Id");
        }
    }
}
