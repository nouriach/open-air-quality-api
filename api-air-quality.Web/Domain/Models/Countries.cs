using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Domain.Models
{
    public class Countries : Rootobject
    {
        [JsonProperty("results", Required = Required.Always)]
        public Country[] Result { get; set; }

        public class Country
        {
            public string code { get; set; }
            public string name { get; set; }
            public int locations { get; set; }
            public DateTime firstUpdated { get; set; }
            public DateTime lastUpdated { get; set; }
            public string[] parameters { get; set; }
            public int cities { get; set; }
            public int sources { get; set; }
        }
    }
}
