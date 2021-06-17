﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Domain.Models
{
    public class Rootobject
    {
        public Meta meta { get; set; }
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
}
