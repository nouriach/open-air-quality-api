using System;

namespace api_air_quality.Web.Domain.Models
{
    public class Cities : Rootobject
    {
        public City[] results { get; set; }
        public class City
        {
            public string country { get; set; }
            public string city { get; set; }
            public int locations { get; set; }
            public DateTime firstUpdated { get; set; }
            public DateTime lastUpdated { get; set; }
            public string[] parameters { get; set; }
        }

    }
}
