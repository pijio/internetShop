using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetShop.DAL.Migrations
{
    public partial class newprop2_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscVolume",
                table: "ProductsCharacteristics");

            migrationBuilder.AddColumn<string>(
                name: "DiscVolAndType",
                table: "ProductsCharacteristics",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscVolAndType",
                table: "ProductsCharacteristics");

            migrationBuilder.AddColumn<int>(
                name: "DiscVolume",
                table: "ProductsCharacteristics",
                type: "integer",
                nullable: true);
        }
    }
}
