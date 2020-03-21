using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiMiniProject.WeatherService.DataHandling
{
    public class CurrentWeatherDTO
    {

        // The class is the model of data.
        public CurrentWeatherRoot CurrentWeather { get; set; }

        // Method that creates the above object following passing in the response from the API
        public void DeserializeLatestRates(string LatestRatesResponse)
        {
            CurrentWeather = JsonConvert.DeserializeObject<CurrentWeatherRoot>(LatestRatesResponse);
        }
    }
}
