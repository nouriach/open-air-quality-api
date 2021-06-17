using api_air_quality.Web.Application.Services.Cities.ViewModels;
using api_air_quality.Web.Application.Services.Countries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services
{
    public class HomepageViewModel
    {
        public HomepageViewModel(CitiesViewModel cities)
        {
            Cities = cities;
            Countries = new CountriesViewModel();
        }

        public HomepageViewModel(CountriesViewModel countries)
        {
            Countries = countries;
            Cities = new CitiesViewModel();
        }
        public HomepageViewModel(CitiesViewModel cities, CountriesViewModel countries)
        {
            Cities = cities;
            Countries = countries;
        }
        public CitiesViewModel Cities { get; set; }
        public CountriesViewModel Countries { get; set; }
    }
}
