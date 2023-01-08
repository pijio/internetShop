using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetShop.DAL.Migrations
{
    public partial class ordernavpropfix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdressAndComment",
                table: "OrderDetails",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "OrderDetails",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "OrderDetails",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdressAndComment",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "OrderDetails");
        }
    }
}
