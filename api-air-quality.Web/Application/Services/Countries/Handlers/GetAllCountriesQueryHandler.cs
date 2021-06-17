using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.Countries.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services.Countries.Handlers
{
    public class GetAllCountriesQueryHandler : IRequestHandler<GetAllCountriesQuery, Domain.Models.Countries>
    {
        private readonly IApiService _service;

        public GetAllCountriesQueryHandler(IApiService service)
        {
            _service = service;
        }
        public async Task<Domain.Models.Countries> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
        {
            var countries = await _service.GetAllCountriesAsync(request);
            return countries;
        }
    }
}
