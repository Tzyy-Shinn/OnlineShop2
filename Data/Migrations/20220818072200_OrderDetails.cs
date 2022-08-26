using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShop2.Data.Migrations
{
    public partial class OrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_PorductId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "PorductId",
                table: "OrderDetails",
                newName: "ProductOId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_PorductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductOId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductOId",
                table: "OrderDetails",
                column: "ProductOId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductOId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductOId",
                table: "OrderDetails",
                newName: "PorductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductOId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_PorductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_PorductId",
                table: "OrderDetails",
                column: "PorductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
