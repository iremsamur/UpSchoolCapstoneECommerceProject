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
        public EfItemDal(Context context) : base(context)
        {
        }
    }
}
