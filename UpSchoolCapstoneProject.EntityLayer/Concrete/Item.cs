using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchoolCapstoneProject.EntityLayer.Concrete
{
    public class Item : BaseEntity
    {

        //tüm genel satılık/kiralık ilanı verilebilen ürünleri temsil eder
        [Key]
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string ShowcaseImage { get; set; }
        public ItemDetail Detail { get; set; }
        public int DetailID { get; set; }
        public SubCategory SubCategory { get; set; }
        public int SubCategoryID { get; set; }
        public ItemImage Image { get; set; }
        public int ImageID { get; set; }
    }
}
