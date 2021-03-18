using BDDElectricityBillKata.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

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
    }
}
