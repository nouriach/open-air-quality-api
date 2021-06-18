using api_air_quality.Web.Application.Services.AirQuality.Queries;
using api_air_quality.Web.Application.Services.Cities.Queries;
using api_air_quality.Web.Application.Services.Countries.Queries;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Common
{
    public interface IApiService
    {
        Task<Domain.Models.Countries> GetAllCountriesAsync(GetAllCountriesQuery query);
        Task<Domain.Models.Cities> GetCitiesByCountryCodeAsync(GetCitiesByCountryQuery query);
        Task<Domain.Models.AirQuality> GetAirQualityForCityAsync(GetAirQualityForCityQuery query);
    }
}
