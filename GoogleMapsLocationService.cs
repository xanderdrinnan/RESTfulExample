///API Key
///Key is currently restricted to Places and Maps API's
//AIzaSyB73fANbXZU3mIPRekVflLNNKAR1ruXnms
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static RESTfulExample.Location;

namespace RESTfulExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GoogleMapsLocationService" in both code and config file together.
    public class GoogleMapsLocationService : IGoogleMapsLocationService
    {
        //Probably a better way to do this but for now, breaking uber long string down into 3 parts with array
        //Can be called using WebRequest.Create(requestUrl[0] + [1] + 2[]
        string placeSearch = "";
        string requestUrl = "";

        public LocationInfo locationReturn(string locationName)
        {
            placeSearch = locationName;
            requestUrl = String.Format("https://maps.googleapis.com/maps/api/place/findplacefromtext/json?input=" + placeSearch + "&inputtype=textquery&fields=photos,formatted_address,name,opening_hours,rating&locationbias=circle:2000@47.6918452,-122.2226413&key=AIzaSyB73fANbXZU3mIPRekVflLNNKAR1ruXnms");
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

            //Convert JSON to Objects
            var jsonObject = JsonConvert.DeserializeObject<RootObject>(result);

            //See Location Class for What "Candidates" Is
            //Candidates.name outputs the full, proper name of the location entered
            string status = jsonObject.status;
            List<Candidate> list = jsonObject.candidates;
            LocationInfo locationInfo = new LocationInfo();
            locationInfo.Address = list[0].formatted_address;
            locationInfo.Name = list[0].name;
            locationInfo.Rating = list[0].rating;

            return locationInfo;
        }
    }
}