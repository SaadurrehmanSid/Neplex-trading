using Microsoft.EntityFrameworkCore.Migrations;

namespace Neplex_trading.Migrations
{
    public partial class deleteSizeFieldFromProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductSize",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductSize",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }
    }
}
