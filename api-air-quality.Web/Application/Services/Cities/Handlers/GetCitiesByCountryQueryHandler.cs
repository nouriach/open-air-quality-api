using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.Cities.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services.Cities.Handlers
{
    public class GetCitiesByCountryQueryHandler : IRequestHandler<GetCitiesByCountryQuery, Domain.Models.Cities>
    {
        private readonly IApiService _service;

        public GetCitiesByCountryQueryHandler(IApiService service)
        {
            _service = service;
        }
        public Task<Domain.Models.Cities> Handle(GetCitiesByCountryQuery request, CancellationToken cancellationToken)
        {
            var cities = _service.GetCitiesByCountryCodeAsync(request);
            return cities;
        }
    }
}
