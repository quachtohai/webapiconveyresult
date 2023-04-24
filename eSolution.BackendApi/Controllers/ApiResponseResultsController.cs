using eSolution.Service;
using eSolution.ViewModels.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eSolution.BackendApi.Controllers
{
    [Authorize]
    public class ApiResponseResultsController : ApiController
    {
        #region Initialize
        private IApiResponseResultsService _resultsService;

        public ApiResponseResultsController(IApiResponseResultsService resultsService)

        {
            this._resultsService = resultsService;
        }

        #endregion
        [System.Web.Http.AcceptVerbs("GET", "HEAD", "OPTIONS")]
        public IEnumerable<ApiResponseResults> GetAll(DateTime fromdate, DateTime todate)
        {
            return _resultsService.GetResults(fromdate, todate);
        }
        [System.Web.Http.AcceptVerbs("POST", "HEAD", "OPTIONS")]
        public ApiResponseResults Create(ApiResponseResults result)
        {
            result.CreatedDate = DateTime.Now;
            return _resultsService.Create(result);
        }

    }
}
