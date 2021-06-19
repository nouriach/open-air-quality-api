using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.AirQuality.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services.AirQuality.Handlers
{
    public class GetAirQualityForCityQueryHandler : IRequestHandler<GetAirQualityForCityQuery, Domain.Models.AirQuality>
    {
        private readonly IApiService _service;
        public GetAirQualityForCityQueryHandler(IApiService service)
        {
            _service = service;
        }
        public async Task<Domain.Models.AirQuality> Handle(GetAirQualityForCityQuery request, CancellationToken cancellationToken)
        {
            var result = await _service.GetAirQualityForCityAsync(request);
            return result;
        }
    }
}
