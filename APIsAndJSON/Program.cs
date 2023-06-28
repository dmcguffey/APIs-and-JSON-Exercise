using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------");
            var convo = new RonVSKanyeAPI();

            for (int i = 0; i < 5; i++)
            {
                convo.Ron();

                convo.Kanye();

                Console.WriteLine("==============");
            }

            Console.WriteLine("------------------------------------------------------------------");
            var weather = new OpenWeatherMapAPI();

            weather.currentWeather("birmingham");
        }
    }
}
