using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Domain.Models
{
    public class AirQuality : Rootobject
    {
        public AirQualityInfo[] results { get; set; }

        public class AirQualityInfo
        {
            public string location { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public Coordinates coordinates { get; set; }
            public Measurement[] measurements { get; set; }
        }

        public class Coordinates
        {
            public float latitude { get; set; }
            public float longitude { get; set; }
        }

        public class Measurement
        {
            public string parameter { get; set; }
            public string value { get; set; }
            public DateTime lastUpdated { get; set; }
            public string unit { get; set; }
        }

    }
}
