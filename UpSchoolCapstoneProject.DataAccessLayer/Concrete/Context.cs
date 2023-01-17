using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchoolCapstoneProject.EntityLayer.Concrete;

namespace UpSchoolCapstoneProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
      
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemDetail> ItemDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }
        public DbSet<ItemDiscountScore> ItemDiscountScores { get; set; }
        public DbSet<ItemRatings> ItemRatings { get; set; }
  
    }
}
