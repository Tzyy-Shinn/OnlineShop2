using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShop2.Data.Migrations
{
    public partial class addsomethingformodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "proQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "addressC",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "budgetLimAmount",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "budgetlimit",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "proQuantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "addressC",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "budgetLimAmount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "budgetlimit",
                table: "AspNetUsers");
        }
    }
}
