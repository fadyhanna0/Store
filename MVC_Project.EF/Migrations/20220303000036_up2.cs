using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Project.EF.Migrations
{
    public partial class up2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_Food_Id",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "Food_Id",
                table: "OrderItems",
                newName: "Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_Food_Id",
                table: "OrderItems",
                newName: "IX_OrderItems_Product_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_Product_Id",
                table: "OrderItems",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_Product_Id",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "Product_Id",
                table: "OrderItems",
                newName: "Food_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_Product_Id",
                table: "OrderItems",
                newName: "IX_OrderItems_Food_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_Food_Id",
                table: "OrderItems",
                column: "Food_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
