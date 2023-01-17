using System.ComponentModel.DataAnnotations;

namespace UpSchoolCapstoneProject.EntityLayer.Concrete
{
    public class SubCategory : BaseEntity
    {
        [Key]
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }

        public Category Category { get; set; }
        public int CategoryID { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}