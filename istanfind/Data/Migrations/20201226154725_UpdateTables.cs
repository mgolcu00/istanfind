using Microsoft.EntityFrameworkCore.Migrations;

namespace istanfind.Data.Migrations
{
    public partial class UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Score = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    PlaceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FunPlace",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    WebSiteUrl = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    AdressUrl = table.Column<string>(nullable: true),
                    Score = table.Column<double>(nullable: false),
                    DataText = table.Column<string>(nullable: true),
                    TitleText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunPlace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoricalPlace",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    WebSiteUrl = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    AdressUrl = table.Column<string>(nullable: true),
                    Score = table.Column<double>(nullable: false),
                    DataText = table.Column<string>(nullable: true),
                    TitleText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricalPlace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    WebSiteUrl = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    AdressUrl = table.Column<string>(nullable: true),
                    Score = table.Column<double>(nullable: false),
                    DataText = table.Column<string>(nullable: true),
                    TitleText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Park",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    WebSiteUrl = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    AdressUrl = table.Column<string>(nullable: true),
                    Score = table.Column<double>(nullable: false),
                    DataText = table.Column<string>(nullable: true),
                    TitleText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Park", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    WebSiteUrl = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    AdressUrl = table.Column<string>(nullable: true),
                    Score = table.Column<double>(nullable: false),
                    DataText = table.Column<string>(nullable: true),
                    TitleText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    WebSiteUrl = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    AdressUrl = table.Column<string>(nullable: true),
                    Score = table.Column<double>(nullable: false),
                    DataText = table.Column<string>(nullable: true),
                    TitleText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "FunPlace");

            migrationBuilder.DropTable(
                name: "HistoricalPlace");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Park");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "Shop");
        }
    }
}
