using MediatR;

namespace api_air_quality.Web.Application.Services.AirQuality.Queries
{
    public class GetAirQualityForCityQuery : IRequest<Domain.Models.AirQuality>
    {
        public string CountryCode { get; set; }
        public string CityName { get; set; }

    }
}
