using System;
using System.Collections;
using System.Collections.Generic;
using eSolution.Data.Infrastructure;
using System.Linq;
using eSolution.ViewModels.Models.ConveyResults;

namespace eSolution.Data.Repositories
{
    public interface IResultsRepository : IRepository<Results>
    {
        IEnumerable<Results> GetResults(DateTime fromDate, DateTime toDate);

    }
    public class ResultsRepository : RepositoryBase<Results>, IResultsRepository
    {
        public ResultsRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
        public IEnumerable<Results> GetResults(DateTime fromDate, DateTime toDate)
        {
            return DbContext.ConveyResults.Where(x => x.CreatedDate >= fromDate && x.CreatedDate <= toDate)
                .OrderByDescending(y=>y.ID);
        }
    }
}