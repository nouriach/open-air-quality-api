using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services.Cities.Queries
{
    public class GetCitiesByCountryQuery : IRequest<Domain.Models.Cities>
    {
        public string CountryCode { get; set; }
    }
}
