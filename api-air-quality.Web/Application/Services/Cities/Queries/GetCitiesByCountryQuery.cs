using MediatR;

namespace api_air_quality.Web.Application.Services.Cities.Queries
{
    public class GetCitiesByCountryQuery : IRequest<Domain.Models.Cities>
    {
        public string CountryCode { get; set; }
        public string Order { get; set; }
    }
}
