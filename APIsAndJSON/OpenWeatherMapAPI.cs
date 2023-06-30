using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public void currentWeather(string city)
        {
            var apiID = File.ReadAllText("appsettings.json");
            string appID = JObject.Parse(apiID).GetValue("apiKey").ToString();
            var client = new HttpClient();
            //calling API
            string weatherURL = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={appID}";
            //pull results of API
            var weatherResponse = client.GetStringAsync(weatherURL).Result;
            //TWO PARTS: parse the results, then you can get the value you want by naming the object
            var weatherResult = JObject.Parse(weatherResponse).GetValue("main").ToString();

            JObject formatResponse = JObject.Parse(weatherResponse);
            var weatherTemp =formatResponse["main"]["temp"];

            Console.WriteLine($"James Spann: Good morning Alabama! I got my full suit on today so no worries. Your forecast for today is: {weatherResult}");

            Console.WriteLine($"To be clear, the temp is {weatherTemp} degrees Fahrenheit. Have a nice day!");
        }

    }
}
