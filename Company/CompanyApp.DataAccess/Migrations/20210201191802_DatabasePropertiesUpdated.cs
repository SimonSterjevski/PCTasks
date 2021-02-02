using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyApp.DataAccess.Migrations
{
    public partial class DatabasePropertiesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<double>(
                name: "Quantity",
                table: "Deliveries",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "StoreItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreItem_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarehouseItem_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Quantity" },
                values: new object[] { 1, "Shoes", 100.0 });

            migrationBuilder.InsertData(
                table: "WarehouseItem",
                columns: new[] { "Id", "Name", "ProductId", "Quantity", "WarehouseId" },
                values: new object[] { 1, "Shoes", 1, 50.0, 1 });

            migrationBuilder.InsertData(
                table: "WarehouseItem",
                columns: new[] { "Id", "Name", "ProductId", "Quantity", "WarehouseId" },
                values: new object[] { 2, "Shoes", 1, 50.0, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_StoreItem_StoreId",
                table: "StoreItem",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItem_WarehouseId",
                table: "WarehouseItem",
                column: "WarehouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreItem");

            migrationBuilder.DropTable(
                name: "WarehouseItem");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Deliveries",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
