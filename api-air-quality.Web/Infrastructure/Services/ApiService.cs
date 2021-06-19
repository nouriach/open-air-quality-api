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
        private HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AirQuality> GetAirQualityForCityAsync(GetAirQualityForCityQuery query)
        {

            var content = await _httpClient.GetStringAsync($"{baseUrl}latest?city={query.CityName}&country={query.CountryCode}");
            var airQualityData = JsonConvert.DeserializeObject<AirQuality>(content);
            return airQualityData;
        }

        public async Task<Countries> GetAllCountriesAsync(GetAllCountriesQuery query)
        {
            var content = await _httpClient.GetStringAsync($"{baseUrl}countries");
            var countries = JsonConvert.DeserializeObject<Countries>(content);
            return countries;
        }

        public async Task<Cities> GetCitiesByCountryCodeAsync(GetCitiesByCountryQuery query)
        {
            var content = await _httpClient.GetStringAsync($"{baseUrl}cities?country_id={query.CountryCode}");
            var cities = JsonConvert.DeserializeObject<Cities>(content);
            return cities;
        }
    }
}
