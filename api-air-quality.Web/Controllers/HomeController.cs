﻿using api_air_quality.Web.Application.Services;
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
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            GetAllCountriesQuery query = new GetAllCountriesQuery();

            var countries = await _mediator.Send(query);
            CountriesViewModel countriesViewModel = new CountriesViewModel(countries);

            HomepageViewModel hvm = new HomepageViewModel(countriesViewModel);

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

        public async Task<IActionResult> MoreInfo(string countryCodeRequest, string cityRequest)
        {
            GetAirQualityForCityQuery airQualityquery = new GetAirQualityForCityQuery()
            {
                CityName = cityRequest,
                CountryCode = countryCodeRequest
            };

            var airQualityData = await _mediator.Send(airQualityquery);
            AirQualityViewModel airQualityViewModel = new AirQualityViewModel(airQualityData);

            return View(airQualityViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
