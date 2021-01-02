using Microsoft.EntityFrameworkCore.Migrations;

namespace istanfind.Data.Migrations
{
    public partial class addSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Adress", "AdressUrl", "DataText", "ImageUrl", "Name", "PhoneNumber", "Score", "TitleText", "WebSiteUrl" },
                values: new object[] { 1, "adresss", "https://hoohle.com", "testsadjusabdjaskdhnsajbdjsabhdjsbadjbajdbjbsadlhsa", "/wwwroot/images/hotel/2566b854-2767-4db6-964a-935b43be151f.PNG", "ShangitiLa", "2125641235", 0.0, "Yat aşşaa", "www.bombabomba.com" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Adress", "AdressUrl", "DataText", "ImageUrl", "Name", "PhoneNumber", "Score", "TitleText", "WebSiteUrl" },
                values: new object[] { 2, "adresss", "https://hoohle.com", "testsadjusabdjaskdhnsajbdjsabhdjsbadjbajdbjbsadlhsa", "/wwwroot/images/hotel/2566b854-2767-4db6-964a-935b43be151f.PNG", "ShangitiLa", "2125641235", 0.0, "Yat aşşaa", "www.bombabomba.com" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Adress", "AdressUrl", "DataText", "ImageUrl", "Name", "PhoneNumber", "Score", "TitleText", "WebSiteUrl" },
                values: new object[] { 3, "adresss", "https://hoohle.com", "testsadjusabdjaskdhnsajbdjsabhdjsbadjbajdbjbsadlhsa", "/wwwroot/images/hotel/2566b854-2767-4db6-964a-935b43be151f.PNG", "ShangitiLa", "2125641235", 0.0, "Yat aşşaa", "www.bombabomba.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
