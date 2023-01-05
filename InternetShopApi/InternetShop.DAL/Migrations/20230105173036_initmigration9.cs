using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetShop.DAL.Migrations
{
    public partial class initmigration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "InStock",
                table: "Products",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "Products");
        }
    }
}
