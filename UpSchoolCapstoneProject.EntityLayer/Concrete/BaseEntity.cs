using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchoolCapstoneProject.EntityLayer.Concrete
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        //public int CreatedUserID { get; set; }
        //public int UpdatedUserID{ get; set; }
        public bool Status { get; set; }
    }
}
