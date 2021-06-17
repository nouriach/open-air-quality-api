using api_air_quality.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services.Country.ViewModels
{
    public class CountryViewModel
    {
        public CountryViewModel(Rootobject result)
        {

        }

        public string Name { get; set; }
        public int TotalCities { get; set; }

    }
}
