using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchoolCapstoneProject.DataAccessLayer.Abstract;
using UpSchoolCapstoneProject.DataAccessLayer.Concrete;
using UpSchoolCapstoneProject.DataAccessLayer.Repository;
using UpSchoolCapstoneProject.EntityLayer.Concrete;

namespace UpSchoolCapstoneProject.DataAccessLayer.EntityFramework
{
    public class EfItemDal : GenericRepository<Item>, IItemDal
    {
        private readonly Context _context;
        public EfItemDal(Context context) : base(context)
        {
            this._context = context;
        }
        public List<Item> GetItemWithImage()
        {
            var values = _context.Items.Include(x => x.Image).ToList();

            return values;
        }

        public List<Item> GetItemWithImageAndCategoryAndDetail()
        {
            var values = _context.Items.Include(x => x.Image).Include(x => x.SubCategory).Include(x => x.Detail).ToList();

            return values;

        }

        public Item GetItemWithImageAndCategoryByCategory(int CategoryID)
        {
            var value = _context.Items.Include(x => x.Image).Include(x => x.SubCategory).Include(x => x.Detail).Where(x => x.SubCategoryID == CategoryID).FirstOrDefault();

            return value;
        }
        
        public ItemDiscountScoresSpModel GetMostDiscountedItemAllDetails(int CategoryID)
        {
            

            string sql = $"SpGetMostDiscountedItemsByCategory {CategoryID}";
            return _context.ItemDiscountScoresSpModels.FromSqlRaw<ItemDiscountScoresSpModel>(sql).AsEnumerable().FirstOrDefault();
        }

        public ItemRatingsSpModel GetMostLikedItemAllDetails(int CategoryID)
        {
     



            string sql = $"SpGetMostLikedItemsByCategory {CategoryID}";
            return _context.ItemRatingsSpModels.FromSqlRaw<ItemRatingsSpModel>(sql).AsEnumerable().FirstOrDefault();

        }
        
    }
}
