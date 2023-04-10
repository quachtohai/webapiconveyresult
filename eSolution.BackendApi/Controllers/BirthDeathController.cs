using eSolution.apiIntergration.Services;
using eSolution.Utilities.Commons;
using eSolution.ViewModels.Models.SocialInsurances;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace eSolution.BackendApi.Controllers
{
    [Authorize]
    public class BirthDeathController : ApiController
    {
        [System.Web.Http.AcceptVerbs("POST", "HEAD", "OPTIONS")]
        public IntergrationApiResults SendBirthDeathResult(BirthDeathCertificateResult result)
        {
            try
            {

                IntergrationApiResults apiResults;
                var resultCallings = ApiIntergrationsResultClient.PostBirthCertificateResult<Task<object>>(result).Result;
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
