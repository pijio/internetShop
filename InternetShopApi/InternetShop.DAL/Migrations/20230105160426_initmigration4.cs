using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetShop.DAL.Migrations
{
    public partial class initmigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharactId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InfoId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCharacteristics_ProductId",
                table: "ProductsCharacteristics",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAdditInfos_ProductId",
                table: "ProductAdditInfos",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAdditInfos_Products_ProductId",
                table: "ProductAdditInfos",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsCharacteristics_Products_ProductId",
                table: "ProductsCharacteristics",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAdditInfos_Products_ProductId",
                table: "ProductAdditInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCharacteristics_Products_ProductId",
                table: "ProductsCharacteristics");

            migrationBuilder.DropIndex(
                name: "IX_ProductsCharacteristics_ProductId",
                table: "ProductsCharacteristics");

            migrationBuilder.DropIndex(
                name: "IX_ProductAdditInfos_ProductId",
                table: "ProductAdditInfos");

            migrationBuilder.DropColumn(
                name: "CharactId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "InfoId",
                table: "Products");
        }
    }
}
