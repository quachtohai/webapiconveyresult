using eSolution.Data.Infrastructure;
using eSolution.Data.Repositories;
using eSolution.ViewModels.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSolution.Service
{
    public interface IApiResponseResultsService
    {
        ApiResponseResults Create(ApiResponseResults result);
        void Save();
        IEnumerable<ApiResponseResults> GetResults(DateTime fromdate, DateTime todate);
    }
    public class ApiResponseResultsService : IApiResponseResultsService
    {
        IApiReponseResultsRepository _apiresultsRepository;
        IUnitOfWork _unitOfWork;
        public ApiResponseResultsService(IApiReponseResultsRepository apiresultsRepository, IUnitOfWork unitOfWork)
        {
            this._apiresultsRepository = apiresultsRepository;
            this._unitOfWork = unitOfWork;
        }
        public ApiResponseResults Create(ApiResponseResults result)
        {
            try
            {
                _apiresultsRepository.Add(result);
                _unitOfWork.Commit();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<ApiResponseResults> GetResults(DateTime fromdate, DateTime todate)
        {
            return _apiresultsRepository.GetResults(fromdate, todate);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
