using eSolution.apiIntergration.Services;
using eSolution.Utilities.Commons;
using eSolution.ViewModels.Models.SocialInsurances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace eSolution.BackendApi.Controllers
{
    [Authorize]
    public class DriverResultsController : ApiController
    {
        [System.Web.Http.AcceptVerbs("POST", "HEAD", "OPTIONS")]
        public ApiResults SendDriverResult(DriverResult result)
        {
            try
            {

                ApiResults apiResults;
                var resultCallings = ApiDriverResultClient.PostDriverResult<Task<object>>(result).Result;
                bool checkSendingResult = resultCallings.ToString().TryParseJson(out apiResults);
                return apiResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
