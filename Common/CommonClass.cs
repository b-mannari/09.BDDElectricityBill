using BDDElectricityBillKata.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BDDElectricityBillKata.Common
{
    public interface IRepository
    {
        string CallWebApi(string parameters);
    }

    public class CommonClass : IRepository
    {
        string apiResponse;
        readonly string webapi = "https://localhost:44338/api/";
        public string CallWebApi(string parameters)
        {
            using (var httpClient = new HttpClient())
            {
                using var response = httpClient.GetAsync(webapi + parameters).Result;
                if (response.IsSuccessStatusCode)
                {
                    apiResponse = response.Content.ReadAsStringAsync().Result;
                }
            }
            return apiResponse;
        }


        //public async Task CallWebApi(string parameters)
        //{
        //    EnergyChargesBilled model = new EnergyChargesBilled();
        //    using (var client = new HttpClient())
        //    using (var request = new HttpRequestMessage(HttpMethod.Post, webapi))
        //    {
        //        var json = JsonConvert.SerializeObject(model);
        //        using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
        //        {
        //            request.Content = stringContent;
        //            using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
        //            {
        //                response.EnsureSuccessStatusCode();
        //                //log.Error("Create response: " + response);
        //            }
        //        }
        //    }
        //    return response;
        //}
    }
}
