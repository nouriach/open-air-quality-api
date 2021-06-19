using api_air_quality.Web.Application.Services;
using api_air_quality.Web.Application.Services.AirQuality.Queries;
using api_air_quality.Web.Application.Services.AirQuality.ViewModels;
using api_air_quality.Web.Application.Services.Cities.Queries;
using api_air_quality.Web.Application.Services.Cities.ViewModels;
using api_air_quality.Web.Application.Services.Countries.Queries;
using api_air_quality.Web.Application.Services.Countries.ViewModels;
using api_air_quality.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace api_air_quality.Web.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            GetAllCountriesQuery query = new GetAllCountriesQuery();

            var countries = await _mediator.Send(query);
            CountriesViewModel countriesViewModel = new CountriesViewModel(countries);

            HomepageViewModel hvm = new HomepageViewModel(null, countriesViewModel);

            return View(hvm);
        }

        [HttpPost]
        public async Task<IActionResult> Index(string countryCodeRequest)
        {
            // GET ALL CITIES FROM A COUNTRY
            GetCitiesByCountryQuery query = new GetCitiesByCountryQuery
            {
                CountryCode = countryCodeRequest
            };

            var cities = await _mediator.Send(query);
            CitiesViewModel citiesViewModel = new CitiesViewModel(cities);

            // GET ALL COUNTRIES
            GetAllCountriesQuery countriesQuery = new GetAllCountriesQuery();
            var countries = await _mediator.Send(countriesQuery);
            CountriesViewModel countriesViewModel = new CountriesViewModel(countries);

            // BUILD HOMEPAGE
            HomepageViewModel hvm = new HomepageViewModel(citiesViewModel, countriesViewModel);

            return View(hvm);
        }

        public async Task<IActionResult> MoreInfo(string countryCodeRequest, string cityRequest)
        {
            //// GET AIR QUALITY DATA FOR A CITY
            GetAirQualityForCityQuery airQualityquery = new GetAirQualityForCityQuery()
            {
                CityName = cityRequest,
                CountryCode = countryCodeRequest
            };

            var airQualityData = await _mediator.Send(airQualityquery);
            AirQualityViewModel airQualityViewModel = new AirQualityViewModel(airQualityData);

            return View(airQualityViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
