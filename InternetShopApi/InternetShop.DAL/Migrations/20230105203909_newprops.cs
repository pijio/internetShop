using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetShop.DAL.Migrations
{
    public partial class newprops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dpi",
                table: "ProductsCharacteristics",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Format",
                table: "ProductsCharacteristics",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatrixType",
                table: "ProductsCharacteristics",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrinterRam",
                table: "ProductsCharacteristics",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelationSide",
                table: "ProductsCharacteristics",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dpi",
                table: "ProductsCharacteristics");

            migrationBuilder.DropColumn(
                name: "Format",
                table: "ProductsCharacteristics");

            migrationBuilder.DropColumn(
                name: "MatrixType",
                table: "ProductsCharacteristics");

            migrationBuilder.DropColumn(
                name: "PrinterRam",
                table: "ProductsCharacteristics");

            migrationBuilder.DropColumn(
                name: "RelationSide",
                table: "ProductsCharacteristics");
        }
    }
}
