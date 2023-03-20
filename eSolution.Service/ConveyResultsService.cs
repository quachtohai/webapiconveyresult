using eSolution.Data.Infrastructure;
using eSolution.Data.Repositories;
using eSolution.ViewModels.Models.ConveyResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSolution.Service
{
    public interface IConveyResultsService
    {
        Results Create(Results conveyresult);
        void Save();
        IEnumerable<Results> GetResults(DateTime fromdate, DateTime todate);
    }

    public class ConveyResultsService : IConveyResultsService
    {
        IResultsRepository _resultsRepository;
        IUnitOfWork _unitOfWork;

        public ConveyResultsService(IResultsRepository resultsRepository, IUnitOfWork unitOfWork)
        {
            this._resultsRepository = resultsRepository;
            this._unitOfWork = unitOfWork;
        }
        public Results Create(Results conveyresult)
        {
            try
            {
                _resultsRepository.Add(conveyresult);
                _unitOfWork.Commit();
                return conveyresult;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<Results> GetResults(DateTime fromdate, DateTime todate)
        {
            return _resultsRepository.GetResults(fromdate, todate);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
