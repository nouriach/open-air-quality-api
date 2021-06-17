using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.AirQuality.Queries;
using api_air_quality.Web.Application.Services.Cities.Queries;
using api_air_quality.Web.Application.Services.Countries.Queries;
using api_air_quality.Web.Domain.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace api_air_quality.Web.Infrastructure.Services
{
    public class ApiService : IApiService
    {
        private readonly string baseUrl = "https://u50g7n0cbj.execute-api.us-east-1.amazonaws.com/v2/";

        public Task<AirQuality> GetAirQualityForCity(GetAirQualityForCityQuery query)
        {
            // api: https://docs.openaq.org/v2/latest?city={query.City}

            throw new System.NotImplementedException();
        }

        public async Task<Countries> GetAllCountriesAsync(GetAllCountriesQuery query)
        {
            HttpClient client = new HttpClient();
            var content = await client.GetStringAsync($"{baseUrl}countries");
            var countries = JsonConvert.DeserializeObject<Countries>(content);
            return countries;
        }

        public async Task<Cities> GetCitiesByCountryCodeAsync(GetCitiesByCountryQuery query)
        {
            HttpClient client = new HttpClient();
            var content = await client.GetStringAsync($"{baseUrl}cities?country_id={query.CountryCode}");
            var cities = JsonConvert.DeserializeObject<Cities>(content);
            return cities;
        }
    }
}
