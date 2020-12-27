using Microsoft.EntityFrameworkCore.Migrations;

namespace istanfind.Data.Migrations
{
    public partial class AddImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Shop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Restaurant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Park",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Hotel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "HistoricalPlace",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "FunPlace",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Park");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "HistoricalPlace");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "FunPlace");
        }
    }
}
