using api_air_quality.Web.Application.Services.Cities.ViewModels;
using api_air_quality.Web.Application.Services.Countries.ViewModels;
using System.Linq;

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
            SelectedCountry = countries.Countries.Where(c => c.Key == cities.Country).FirstOrDefault().Value;
        }
        public CitiesViewModel Cities { get; set; }
        public CountriesViewModel Countries { get; set; }
        public string SelectedCountry { get; private set; }

    }
}
