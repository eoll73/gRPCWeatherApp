using GrpcGreeter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace GrpcGreeter.API
{
    public class ApiService : IApiService
    {
        public Weather GetWeather(string key)
        {
            var client = new RestClient("http://api.openweathermap.org/data/2.5/weather?q=Kirov,ru");
            var request = new RestRequest(Method.GET);
            request.AddParameter("APPID", key);
            IRestResponse response = client.Execute(request);

            var content = response.Content;
            var resault = JsonConvert.DeserializeObject<Weather>(content);
            return resault;
        }

    }
}