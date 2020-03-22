using RestSharp;
using System;

namespace ApiMiniProject.HTTPManager
{
    public class WeatherCallManager
    { 
        private readonly IRestClient client;

        

        public WeatherCallManager()
        {
            client = new RestClient(AppConfigReader.BaseUrl);
        }

        public string GetCurrentWeather()
        {
            //api.openweathermap.org / data / 2.5 / weather ? q = Walsall & appid = 8d019877566f0c8990aa04677d8eda4a
            var request = new RestRequest("weather?q=Walsall&appid=" + AppConfigReader.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

        //public string StatusCode(int cod)
        //{
        //    var request = new RestRequest($"/weather?q={cod}&" + AppConfigReader.ApiKey);
        //    var response = client.Execute(request, Method.GET);
        //    return response.Content;
        //}

        public string GetCurrentWeather1()
        {
            //api.openweathermap.org / data / 2.5 / weather ? q = Walsall & appid = 8d019877566f0c8990aa04677d8eda4a
            var request = new RestRequest("weather?q=W&appid=" + AppConfigReader.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

      


    }
}
