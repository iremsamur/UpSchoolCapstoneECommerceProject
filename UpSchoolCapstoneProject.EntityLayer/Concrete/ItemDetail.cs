using System.ComponentModel.DataAnnotations;

namespace UpSchoolCapstoneProject.EntityLayer.Concrete
{
    public class ItemDetail : BaseEntity
    {
        [Key]
        public int ItemDetailID { get; set; }
        //diğer detay bilgiler gelecek
        public string ItemNo { get; set; }//ürün no-ilan no
        //brandID gelir marka için diğerleri sonra eklenecek
        public double NewPrice { get; set; }
        public double OldPrice { get; set; }
        public double DiscountRate { get; set; }
        public DateTime AnnouncementDate { get; set; }//ilan tarihi
        public ICollection<Item> Items { get; set; }
    }
}