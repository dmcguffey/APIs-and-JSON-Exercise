using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public void  Ron()
        {
            //httpclient is used to access the web
            var client = new HttpClient();

            //url for the RON SWANSON API
            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            //sends a GET request and returns a string
            var ronResponse = client.GetStringAsync(ronURL).Result;

            //ron's response is in array format. must be parsed as JArray
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron: {ronQuote}");
        }

        public void Kanye()
        {
            var client = new HttpClient();


            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            Console.WriteLine($"Kanye: {JObject.Parse(kanyeResponse).GetValue("quote").ToString()}");
        }

    }
}
