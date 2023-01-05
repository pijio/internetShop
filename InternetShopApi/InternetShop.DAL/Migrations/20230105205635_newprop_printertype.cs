using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetShop.DAL.Migrations
{
    public partial class newprop_printertype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrinterType",
                table: "ProductsCharacteristics",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrinterType",
                table: "ProductsCharacteristics");
        }
    }
}
