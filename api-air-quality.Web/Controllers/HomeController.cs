using api_air_quality.Web.Application.Services;
using api_air_quality.Web.Application.Services.Cities.Queries;
using api_air_quality.Web.Application.Services.Cities.ViewModels;
using api_air_quality.Web.Application.Services.Countries.Queries;
using api_air_quality.Web.Application.Services.Countries.ViewModels;
using api_air_quality.Web.Application.Services.Country.Queries;
using api_air_quality.Web.Application.Services.Country.ViewModels;
using api_air_quality.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            GetCitiesByCountryQuery query = new GetCitiesByCountryQuery
            {
                CountryCode = countryCodeRequest
            };

            var cities = await _mediator.Send(query);
            CitiesViewModel citiesViewModel = new CitiesViewModel(cities);

            GetAllCountriesQuery countriesQuery = new GetAllCountriesQuery();
            var countries = await _mediator.Send(countriesQuery);
            CountriesViewModel countriesViewModel = new CountriesViewModel(countries);

            HomepageViewModel hvm = new HomepageViewModel(citiesViewModel, countriesViewModel);

            return View(hvm);
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
