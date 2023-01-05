using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetShop.DAL.Migrations
{
    public partial class fixnavprops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAdditInfos_Products_ProductId",
                table: "ProductAdditInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCharacteristics_Products_ProductId",
                table: "ProductsCharacteristics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsCharacteristics",
                table: "ProductsCharacteristics");

            migrationBuilder.DropIndex(
                name: "IX_ProductsCharacteristics_ProductId",
                table: "ProductsCharacteristics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAdditInfos",
                table: "ProductAdditInfos");

            migrationBuilder.DropIndex(
                name: "IX_ProductAdditInfos_ProductId",
                table: "ProductAdditInfos");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductsCharacteristics");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductAdditInfos");

            migrationBuilder.AlterColumn<double>(
                name: "ScreenSize",
                table: "ProductsCharacteristics",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ram",
                table: "ProductsCharacteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdditInfoInfoId",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacteristicsCharactId",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsCharacteristics",
                table: "ProductsCharacteristics",
                column: "CharactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAdditInfos",
                table: "ProductAdditInfos",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AdditInfoInfoId",
                table: "Products",
                column: "AdditInfoInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CharacteristicsCharactId",
                table: "Products",
                column: "CharacteristicsCharactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductAdditInfos_AdditInfoInfoId",
                table: "Products",
                column: "AdditInfoInfoId",
                principalTable: "ProductAdditInfos",
                principalColumn: "InfoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsCharacteristics_CharacteristicsCharactId",
                table: "Products",
                column: "CharacteristicsCharactId",
                principalTable: "ProductsCharacteristics",
                principalColumn: "CharactId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductAdditInfos_AdditInfoInfoId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsCharacteristics_CharacteristicsCharactId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsCharacteristics",
                table: "ProductsCharacteristics");

            migrationBuilder.DropIndex(
                name: "IX_Products_AdditInfoInfoId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CharacteristicsCharactId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAdditInfos",
                table: "ProductAdditInfos");

            migrationBuilder.DropColumn(
                name: "AdditInfoInfoId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CharacteristicsCharactId",
                table: "Products");

            migrationBuilder.AlterColumn<double>(
                name: "ScreenSize",
                table: "ProductsCharacteristics",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<int>(
                name: "Ram",
                table: "ProductsCharacteristics",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductsCharacteristics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductAdditInfos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsCharacteristics",
                table: "ProductsCharacteristics",
                columns: new[] { "CharactId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAdditInfos",
                table: "ProductAdditInfos",
                columns: new[] { "InfoId", "ProductId" });

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
    }
}
