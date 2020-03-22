using ApiMiniProject.HTTPManager;
using ApiMiniProject.WeatherService.DataHandling;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiMiniProject.WeatherService
{ 
    public class CurrentWeatherService
    {
        // Our instance of the call manager that manages the call to the API to get the data
        public WeatherCallManager weatherCallManager = new WeatherCallManager();

        // Our instance of the DTO that transforms our data into the format of our model
        public CurrentWeatherDTO currentWeathertDTO = new CurrentWeatherDTO();

        // The Weather call of the City requested retrieved
        public String currentCity;

        // Weather converted to JObject so we manipulate later in useful methods
        public JObject json_weather;

        public CurrentWeatherService()
        {
            currentCity = weatherCallManager.GetCurrentWeather();
            currentWeathertDTO.DeserializeWeather(currentCity);
            json_weather = JsonConvert.DeserializeObject<JObject>(currentCity);
        }
        
    }


}

