using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetShop.DAL.Migrations
{
    public partial class initmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAdditionalInfos",
                table: "ProductAdditionalInfos");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "ProductAdditionalInfos",
                newName: "ProductAdditInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAdditInfos",
                table: "ProductAdditInfos",
                columns: new[] { "InfoId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAdditInfos",
                table: "ProductAdditInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "ProductAdditInfos",
                newName: "ProductAdditionalInfos");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "ProductCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAdditionalInfos",
                table: "ProductAdditionalInfos",
                columns: new[] { "InfoId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
