using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Italian", "Cake de pizza italien" },
                    { 2, "Indian", "Delice du l'inde aux saveurs incomparables" },
                    { 3, "Cameroonian", "Les tchops du pays qui reveil le spirit" }
                });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 4, null, 1, null, null, false, false, null, "Pizza Scott's", 25m, "Les tchops du pays qui reveil le spirit" },
                    { 3, null, 2, null, null, false, false, null, "Ndole Lave", 43m, "Les tchops du pays qui reveil le spirit" },
                    { 5, null, 2, null, null, false, false, null, "Manioc Tubercule", 500m, "Les tchops du pays qui reveil le spirit" },
                    { 1, null, 3, null, null, false, false, null, "Baskess", 22m, "Cake de pizza italien" },
                    { 2, null, 3, null, null, false, false, null, "Cake Krus", 105m, "Delice du l'inde aux saveurs incomparables" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
