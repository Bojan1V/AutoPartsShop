using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoPartsShop.Migrations
{
    public partial class ShoppingCartItemsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartNameId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_shoppingCartItems_PartNames_PartNameId",
                        column: x => x.PartNameId,
                        principalTable: "PartNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCartItems_PartNameId",
                table: "shoppingCartItems",
                column: "PartNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shoppingCartItems");
        }
    }
}
