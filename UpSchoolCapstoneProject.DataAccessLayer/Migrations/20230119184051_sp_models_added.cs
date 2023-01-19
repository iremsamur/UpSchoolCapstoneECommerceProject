using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpSchoolCapstoneProject.DataAccessLayer.Migrations
{
    public partial class sp_models_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemDiscountScoresSpModels",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemShowcaseImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemTotalDiscountScore = table.Column<double>(type: "float", nullable: false),
                    ItemNewPrice = table.Column<double>(type: "float", nullable: false),
                    ItemOldPrice = table.Column<double>(type: "float", nullable: false),
                    ItemDiscount = table.Column<double>(type: "float", nullable: false),
                    ItemDiscountScoreID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDiscountScoresSpModels", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "ItemRatingsSpModels",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemShowcaseImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemRatingID = table.Column<int>(type: "int", nullable: false),
                    ItemTotalRatingScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRatingsSpModels", x => x.ItemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDiscountScoresSpModels");

            migrationBuilder.DropTable(
                name: "ItemRatingsSpModels");
        }
    }
}
