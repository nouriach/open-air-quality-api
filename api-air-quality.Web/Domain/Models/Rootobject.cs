using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Domain.Models
{

    // the below may need to be renamed Rootobject
    public class Rootobject
    {
        public Meta meta { get; set; }
        public Result[] results { get; set; }
    }
    public class Meta
    {
        public string name { get; set; }
        public string license { get; set; }
        public string website { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
        public int found { get; set; }
    }
    public class Result
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
