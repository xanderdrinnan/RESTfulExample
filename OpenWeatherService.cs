//API Key for OpenWeather:
//c7b44d90a1b4bada03a4132a1d9dd9a5
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static RESTfulExample.WeatherData;

namespace RESTfulExample


{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OpenWeatherService" in both code and config file together.
    public class OpenWeatherService : IOpenWeatherService
    {
        string requestUrl;
        public WeatherReport WeatherReturn(string cityFromGAPI, string countryFromGAPI)
        {
            // Need the http:// and appid for url to work, and return metric units
            requestUrl = "http://api.openweathermap.org/data/2.5/weather?q=" +
                cityFromGAPI + "," + countryFromGAPI + "&appid=c7b44d90a1b4bada03a4132a1d9dd9a5" +
                "&units=metric";

            WebRequest requestObjGet = WebRequest.Create(requestUrl);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();

            string result = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                result = sr.ReadToEnd();
                sr.Close();
            }

            // Convert JSON to Objects
            var jsonObject = JsonConvert.DeserializeObject<RootObject>(result);

            // See Location Class for What "Candidates" Is
            // Candidates.name outputs the full, proper name of the location entered
            List<Weather> list = jsonObject.weather;
            Main main = jsonObject.main;

            var report = new WeatherReport();

            report.Description = list[0].description;
            report.TempMax = main.temp_max.ToString();
            report.TempMin = main.temp_min.ToString();

            return report;
        }
    }
}
