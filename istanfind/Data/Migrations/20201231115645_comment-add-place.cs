using Microsoft.EntityFrameworkCore.Migrations;

namespace istanfind.Data.Migrations
{
    public partial class commentaddplace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlaceType",
                table: "Comment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceType",
                table: "Comment");
        }
    }
}
