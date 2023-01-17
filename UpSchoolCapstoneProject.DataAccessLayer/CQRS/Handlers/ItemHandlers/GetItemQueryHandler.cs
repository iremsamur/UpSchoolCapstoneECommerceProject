using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchoolCapstoneProject.DataAccessLayer.Concrete;
using UpSchoolCapstoneProject.DataAccessLayer.CQRS.Queries.ItemQueries;
using UpSchoolCapstoneProject.DataAccessLayer.CQRS.Results.ItemResults;

namespace UpSchoolCapstoneProject.DataAccessLayer.CQRS.Handlers.ItemHandlers
{
    public class GetItemQueryHandler : IRequestHandler<GetItemQuery,List<GetItemQueryResult>>
    {
        private readonly Context _context;

        public GetItemQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetItemQueryResult>> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {

            return await _context.Items.Include(x => x.SubCategory).Include(x => x.Detail).Include(x => x.Image).Select(x =>
            new GetItemQueryResult
            {
                ItemID = x.ItemID,
                Name = x.Name,
                ShowcaseImage = x.ShowcaseImage,
                ItemNo = x.Detail.ItemNo,
                NewPrice = x.Detail.NewPrice,
                OldPrice = x.Detail.OldPrice,
                DiscountRate = x.Detail.DiscountRate,
                AnnouncementDate = x.Detail.AnnouncementDate,
                DetailID = x.DetailID,
                SubCategoryName = x.SubCategory.SubCategoryName,
                SubCategoryID = x.SubCategoryID,
                Picture = x.Image.Picture,
                ImageID = x.ImageID



            }).AsNoTracking().ToListAsync();
           
        }
    }
}
