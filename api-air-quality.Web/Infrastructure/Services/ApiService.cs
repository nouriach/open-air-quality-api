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
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}latest?city={query.CityName}&country={query.CountryCode}");
            using (var response = await _httpClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    var contentResp = await response.Content.ReadAsStringAsync();
                    var airQualityDataRes = JsonConvert.DeserializeObject<AirQuality>(contentResp);
                    return airQualityDataRes;
                }
                return null;
            }
        }

        public async Task<Countries> GetAllCountriesAsync(GetAllCountriesQuery query)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}countries");
            using (var response = await _httpClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    var contentResp = await response.Content.ReadAsStringAsync();
                    var countriesRes = JsonConvert.DeserializeObject<Countries>(contentResp);
                    return countriesRes;
                }
            }
            return null;
        }

        public async Task<Cities> GetCitiesByCountryCodeAsync(GetCitiesByCountryQuery query)
        {
            var orderParam = query.Order == null ? "asc" : query.Order;

            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}cities?sort={orderParam}&country_id={query.CountryCode}");
            using (var response = await _httpClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    var contentResp = await response.Content.ReadAsStringAsync();
                    var citiesRes = JsonConvert.DeserializeObject<Cities>(contentResp);
                    return citiesRes;
                }
                return null;
            }
        }
    }
}
