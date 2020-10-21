using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTfulExample
{
    public class Location
    {
        public class Photo
        {
            public int height { get; set; }
            public List<string> html_attributions { get; set; }
            public string photo_reference { get; set; }
            public int width { get; set; }
        }

        public class Candidate
        {
            public string formatted_address { get; set; }
            public string name { get; set; }
            public double rating { get; set; }
        }

        public class RootObject
        {
            public List<Candidate> candidates { get; set; }
            public string status { get; set; }
        }


        //public string formatted_address { get; set; }
        //public string name { get; set; }
        //public double rating { get; set; }
    }
}
