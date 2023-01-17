using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchoolCapstoneProject.EntityLayer.Concrete
{
    public class ItemRatings : BaseEntity
    {
        //en çok beğenilen ürünleri tutar.
        [Key]
        public int ItemRatingID { get; set; }

        public int TotalRatingScore { get; set; }
        public int RatingCount { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
        //trigger ile beğen butonuna basıldığı anda totalratingi 1 arttırır. Blog örneğindeki gibi
    }
}
