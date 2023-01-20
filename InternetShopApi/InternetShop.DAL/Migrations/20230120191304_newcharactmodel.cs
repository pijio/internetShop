using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace InternetShop.DAL.Migrations
{
    public partial class newcharactmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsCharacteristics_CharacteristicsCharactId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductsCharacteristics");

            migrationBuilder.DropIndex(
                name: "IX_Products_CharacteristicsCharactId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CharactId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CharacteristicsCharactId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCharacteristics",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    CharacteristicId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCharacteristics", x => new { x.ProductId, x.CharacteristicId });
                    table.ForeignKey(
                        name: "FK_ProductCharacteristics_Characteristics_CharacteristicId",
                        column: x => x.CharacteristicId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCharacteristics_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCharacteristics_CharacteristicId",
                table: "ProductCharacteristics",
                column: "CharacteristicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCharacteristics");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.AddColumn<int>(
                name: "CharactId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharacteristicsCharactId",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductsCharacteristics",
                columns: table => new
                {
                    CharactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DiscVolAndType = table.Column<string>(type: "text", nullable: true),
                    Dpi = table.Column<string>(type: "text", nullable: true),
                    Format = table.Column<string>(type: "text", nullable: true),
                    MatrixType = table.Column<string>(type: "text", nullable: true),
                    Os = table.Column<string>(type: "text", nullable: true),
                    PrinterRam = table.Column<string>(type: "text", nullable: true),
                    PrinterType = table.Column<string>(type: "text", nullable: true),
                    Processor = table.Column<string>(type: "text", nullable: true),
                    Ram = table.Column<string>(type: "text", nullable: true),
                    RelationSide = table.Column<string>(type: "text", nullable: true),
                    ScreenSize = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsCharacteristics", x => x.CharactId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CharacteristicsCharactId",
                table: "Products",
                column: "CharacteristicsCharactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsCharacteristics_CharacteristicsCharactId",
                table: "Products",
                column: "CharacteristicsCharactId",
                principalTable: "ProductsCharacteristics",
                principalColumn: "CharactId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
