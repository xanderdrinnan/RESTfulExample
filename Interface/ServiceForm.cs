


using Interface.GMapsServiceReference;
using Interface.OWeatherServiceReference;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(ServiceForm_Closing);
        }

        GMapsServiceReference.GoogleMapsLocationServiceClient gMapsRef = new GMapsServiceReference.GoogleMapsLocationServiceClient();
		OWeatherServiceReference.OpenWeatherServiceClient oWeatherRef = new OWeatherServiceReference.OpenWeatherServiceClient();
        LocationInfo locationInfo = new LocationInfo();
        WeatherReport weatherReport = new WeatherReport();

        string locationName;
        string cityFromGAPI;
        string countryFromGAPI;
        FindCityAndCountry fc = new FindCityAndCountry();

        private void locationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                locationName = locationBox.Text.Trim();
                locationInfo = gMapsRef.locationReturn(locationName);

                //Get the city from location information for the weather
                cityFromGAPI = fc.FindCity(locationInfo.Address);

                //Get the country from location information for the weather
                countryFromGAPI = fc.FindCountry(locationInfo.Address);

                if (cityFromGAPI == "False Entry" || countryFromGAPI == "False Entry")
                {
                    outputRich.Text = "Try a place, not a city or country!";
                }
                else
                {
                    weatherReport = oWeatherRef.WeatherReturn(cityFromGAPI, countryFromGAPI);

                    outputRich.Text =
                    "Address: " + locationInfo.Address + "\n" +
                    "Location Name: " + locationInfo.Name + "\n" +
                    "Rating: " + locationInfo.Rating + "\n\n" +
                    "Weather Description: " + weatherReport.Description + "\n" +
                    "High Of: " + weatherReport.TempMax + " degrees\n" +
                    "Low Of: " + weatherReport.TempMin + " degrees\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ServiceForm_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}