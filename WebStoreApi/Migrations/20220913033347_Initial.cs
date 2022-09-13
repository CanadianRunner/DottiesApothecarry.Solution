using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebStoreApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Price = table.Column<double>(type: "double", nullable: false),
                    InStockQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Description", "InStockQty", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Organic lavendar, sold by the pound", 100, "Lavendar", 5.0 },
                    { 2, "Organic Chamomile, sold by the pound", 45, "Chamomile", 8.5 },
                    { 3, "White Sage Smudge Sticks, packs of 4", 35, "Sage Sticks", 7.0 },
                    { 4, "25ml glass vial, sold in cases of 10", 15, "Glass Vial - 25ml", 30.0 },
                    { 5, "Tools used for blood letting, kit includes: 1 fleam, 1 thumb lancet, 4 cups, and live leaches ", 3, "Blood Letting Starter Pack", 300.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
