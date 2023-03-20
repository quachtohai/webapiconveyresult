using eSolution.Service;
using eSolution.ViewModels.Models.ConveyResults;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace eSolution.BackendApi.Controllers
{
    [Authorize]
    public class ResultsController : ApiController
    {
        #region Initialize
        private IConveyResultsService _conveyResultsService;

        public ResultsController(IConveyResultsService conveyResultsService)
            
        {
            this._conveyResultsService = conveyResultsService;
        }

        #endregion
        [System.Web.Http.AcceptVerbs("GET", "HEAD", "OPTIONS")]        
        public IEnumerable<Results> GetAll(DateTime fromdate, DateTime todate)
        {
            return _conveyResultsService.GetResults(fromdate, todate);
        }
        [System.Web.Http.AcceptVerbs("POST", "HEAD", "OPTIONS")]
        public Results Create(Results result)
        {
            result.CreatedDate = DateTime.Now;
            return _conveyResultsService.Create(result);
        }
        [System.Web.Http.AcceptVerbs("GET", "HEAD", "OPTIONS")]
        public string GetOne(string id)
        {
            return "Success";
        }
    }
}
