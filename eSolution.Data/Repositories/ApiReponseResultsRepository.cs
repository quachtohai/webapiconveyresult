using eSolution.Data.Infrastructure;
using eSolution.ViewModels.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSolution.Data.Repositories
{
    public interface IApiReponseResultsRepository : IRepository<ApiResponseResults>
    {
        IEnumerable<ApiResponseResults> GetResults(DateTime fromDate, DateTime toDate);

    }
    public class ApiReponseResultsRepository : RepositoryBase<ApiResponseResults>, IApiReponseResultsRepository
    {
        public ApiReponseResultsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
        public IEnumerable<ApiResponseResults> GetResults(DateTime fromDate, DateTime toDate)
        {
            return DbContext.ApiResponseResults.Where(x => x.CreatedDate >= fromDate && x.CreatedDate <= toDate)
                .OrderByDescending(y => y.ID);
        }
    }
}
