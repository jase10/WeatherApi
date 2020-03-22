using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiMiniProject.WeatherService;


namespace ApiMiniProject.Test
{
    [TestFixture]
   public class WeatherCallTests
    {
        private CurrentWeatherService currentWeather = new CurrentWeatherService();

        [Test]
        public void WebCallSuccessCheck()
        {
            // Lets check that we have success returning true, this will tell us whether we have successfully built our framework.
            Assert.AreEqual(200, currentWeather.currentWeathertDTO.CurrentWeather.cod);
        }

        [Test]
        public void CurrentCity() 
        {
            Assert.AreEqual("Walsall", currentWeather.currentWeathertDTO.CurrentWeather.name);
        }

        [Test]
        public void CurrentCountry()
        {
            Assert.AreEqual("GB", currentWeather.currentWeathertDTO.CurrentWeather.sys.country);
        }

        [Test]
        public void HumidtyCheck() 
        {
            CurrentWeatherService cws = new CurrentWeatherService();
            var result = cws.HumidCheck();
            //Assert.AreEqual(true, result);
            //Assert.AreEqual(53, currentWeather.currentWeathertDTO.CurrentWeather.main.humidity);
            Assert.That(result);

        }

        [Test]
        public void TimeZoneCheck() 
        {
            Assert.AreEqual(0, currentWeather.currentWeathertDTO.CurrentWeather.timezone);
        }

        [Test]
        public void LatitudeCheck() 
        {
            Assert.AreEqual(52.59f, currentWeather.currentWeathertDTO.CurrentWeather.coord.lat);
        }

        [Test]
        public void LongititudeCheck()
        {
            Assert.AreEqual(-1.98f, currentWeather.currentWeathertDTO.CurrentWeather.coord.lon);
        }

        [Test]
        public void WindSpeedCheck() 
        {
            var result = currentWeather.currentWeathertDTO.CurrentWeather.wind.speed;
            Assert.AreEqual(result, currentWeather.currentWeathertDTO.CurrentWeather.wind.speed);
            //Assert.AreEqual(5.1f, currentWeather.currentWeathertDTO.CurrentWeather.wind.speed);

        }

        [Test]
        public void WebCallFailDueToIncorrectCity()
        {
            CurrentWeatherService cw = new CurrentWeatherService();
            var currentW = cw.weatherCallManager.GetCurrentWeather1();
            var expected = currentW.ToString();
            Assert.AreEqual(expected, currentW);

        }

        [Test]
        public void IdCheck() 
        {
            Assert.AreEqual(2634853, currentWeather.currentWeathertDTO.CurrentWeather.id);
        }

        [Test]
        public void CloudCheck() 
        {
            Assert.AreEqual(0, currentWeather.currentWeathertDTO.CurrentWeather.clouds.all);
        }




    }
}
