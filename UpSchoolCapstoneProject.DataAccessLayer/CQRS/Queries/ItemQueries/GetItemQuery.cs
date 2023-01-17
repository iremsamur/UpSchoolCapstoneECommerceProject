using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchoolCapstoneProject.DataAccessLayer.CQRS.Results.ItemResults;

namespace UpSchoolCapstoneProject.DataAccessLayer.CQRS.Queries.ItemQueries
{
    public class GetItemQuery : IRequest<List<GetItemQueryResult>>
    {
    }
}
