using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpSchoolCapstoneProject.DataAccessLayer.Migrations
{
    public partial class mig_SpGetMostDiscountedItemsByCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create Procedure SpGetMostDiscountedItemsByCategory
                                 @SubCategoryID int
                                 as 
                                 Begin
                                 Select 
                                 Items.Name,Items.ShowcaseImage,SubCategories.SubCategoryName,ItemDiscountScores.ItemDiscountScoreID,
                                 ItemDiscountScores.TotalDiscountScore,Items.ItemID,ItemDetails.DiscountRate,
                                 ItemDetails.OldPrice,ItemDetails.NewPrice
                                 from Items,SubCategories,ItemDetails,ItemDiscountScores 
                                 where ItemDiscountScores.ItemID=Items.ItemID and Items.SubCategoryID=SubCategories.SubCategoryID 
                                 and Items.DetailID=ItemDetails.ItemDetailID and 
                                 ItemDiscountScores.TotalDiscountScore=(Select MAX(ItemDiscountScores.TotalDiscountScore) from ItemDiscountScores,Items,SubCategories where ItemDiscountScores.ItemID=Items.ItemID and Items.SubCategoryID=SubCategories.SubCategoryID and SubCategories.SubCategoryID=@SubCategoryID group by SubCategories.SubCategoryID)                           
                                 End;";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //code firstden store procedure yazdığımız procedure'ü silmek için
            string procedure = @"Drop Procedure SpGetMostDiscountedItemsByCategory";
            migrationBuilder.Sql(procedure);

        }
    }
}
