using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class FindCityAndCountry
    {
        //Works if you put in a non-city (ie. Conestoga)
        public string FindCity(string location)
        {
            try
            {
                //Find everything between the first two commas = city
                String[] chunks = location.Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                string city = chunks[1].Trim();

                return city;
            }
            catch (Exception e)
            {
                return "False Entry";
            }
        }

        public string FindCountry(string location)
        {
            try
            {
                //Find everything after the last comma = country
                String[] chunks = location.Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                string country = chunks[3].Trim();

                return country;
            }
            catch (Exception e)
            {
                return "False Entry";
            }
        }
    }
}
