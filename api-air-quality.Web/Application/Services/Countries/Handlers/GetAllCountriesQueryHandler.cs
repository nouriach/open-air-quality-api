using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.Countries.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services.Countries.Handlers
{
    public class GetAllCountriesQueryHandler : IRequestHandler<GetAllCountriesQuery, Domain.Models.Rootobject>
    {
        private readonly IApiService _service;

        public GetAllCountriesQueryHandler(IApiService service)
        {
            // dependency injection here to speak to a api service within infrastructure
            _service = service;
        }
        public async Task<Domain.Models.Rootobject> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
        {
            var countries = await _service.GetAllCountriesAsync(request);
            return countries;
        }
    }
}
