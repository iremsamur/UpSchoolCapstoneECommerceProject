using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpSchoolCapstoneProject.DataAccessLayer.Migrations
{
    public partial class mig_SpGetMostLikedItemsByCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create Procedure SpGetMostLikedItemsByCategory
                                @SubCategoryID int
                                as 
                                Begin
                                Select Items.Name,Items.ShowcaseImage,SubCategories.SubCategoryName,ItemRatings.TotalRatingScore,ItemRatings.ItemRatingID,Items.ItemID from ItemRatings,Items,SubCategories where ItemRatings.ItemID=Items.ItemID and Items.SubCategoryID=SubCategories.SubCategoryID and ItemRatings.TotalRatingScore=(Select MAX(ItemRatings.TotalRatingScore) from ItemRatings,Items,SubCategories where ItemRatings.ItemID=Items.ItemID and Items.SubCategoryID=SubCategories.SubCategoryID and SubCategories.SubCategoryID=@SubCategoryID group by SubCategories.SubCategoryID)
	
                                End";
            migrationBuilder.Sql(procedure);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //code firstden store procedure yazdığımız procedure'ü silmek için
            string procedure = @"Drop Procedure SpGetMostLikedItemsByCategory";
            migrationBuilder.Sql(procedure);
        }
    }
}
