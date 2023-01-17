using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchoolCapstoneProject.EntityLayer.Concrete
{
    public class Category : BaseEntity
    {
        [Key]
        public int CategoryID { get; set; }
        public string Title { get; set; }
       
    }
}
