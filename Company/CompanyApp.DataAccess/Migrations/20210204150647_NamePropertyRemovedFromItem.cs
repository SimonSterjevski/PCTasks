using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyApp.DataAccess.Migrations
{
    public partial class NamePropertyRemovedFromItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "WarehouseItem");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "StoreItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WarehouseItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StoreItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "WarehouseItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "WarehouseItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Shoes");
        }
    }
}
