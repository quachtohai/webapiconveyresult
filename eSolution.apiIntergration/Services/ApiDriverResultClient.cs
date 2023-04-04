using eSolution.Utilities.Commons;
using eSolution.ViewModels.Models.SocialInsurances;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace eSolution.apiIntergration.Services
{
    public static class ApiDriverResultClient
    {
        public static async Task<object> PostDriverResult<TResponse>(DriverResult driverResult)        {

            var json = JsonConvert.SerializeObject(driverResult);

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
                     MediaTypeWithQualityHeaderValue("application/json"));
            client.BaseAddress = new Uri(Constants.BASE_URI_BAO_HIEM_XA_HOI);
            client.DefaultRequestHeaders.Add(Constants.USER_NAME, Constants.USER_BAOHIEM);
            client.DefaultRequestHeaders.Add(Constants.PASSWORD, Constants.PASSWORD_BAOHIEM);
            var response = client.PostAsync(Constants.GUI_KET_QUA_LAI_XE, httpContent).Result;
            var bodyResponse = response.Content.ReadAsStringAsync();
           
            return bodyResponse.Result;

        }
    }
}
