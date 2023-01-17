using System.ComponentModel.DataAnnotations;

namespace UpSchoolCapstoneProject.EntityLayer.Concrete
{
    public class ItemImage : BaseEntity
    {
        [Key]
        public int ItemImageID { get; set; }
        public string Picture { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}