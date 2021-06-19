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
            // there could be a separate all here to get single country information based on the request 
            // so in the view it could say: "All results for X, last updated Y"
            return cities;
        }
    }
}
