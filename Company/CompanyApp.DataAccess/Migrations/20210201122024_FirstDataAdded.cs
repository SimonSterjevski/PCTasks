using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyApp.DataAccess.Migrations
{
    public partial class FirstDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Location", "Manager", "Size", "StoreType" },
                values: new object[] { 1, "Karpos4", "Nino Ninov", 55.0, 2 });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 1, "FinishedGoods1", 111222333 });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 2, "FinishedGoods2", 111222334 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
