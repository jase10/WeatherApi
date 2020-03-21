using RestSharp;


namespace ApiMiniProject.HTTPManager
{
   
    public class WeatherCallManager
    { 
        private readonly IRestClient client;

        public WeatherCallManager()
        {
            client = new RestClient(AppConfigReader.BaseUrl);
        }

        public string GetCurrentWeather(string city)
        {
            
            var request = new RestRequest($"/weather?q={city}&" + AppConfigReader.ApiUrlMod + AppConfigReader.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string StatusCode(int cod)
        {
            var request = new RestRequest($"/weather?q={cod}&" + AppConfigReader.ApiUrlMod + AppConfigReader.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

        
    }
}
