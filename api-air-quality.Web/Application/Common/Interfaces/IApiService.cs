using api_air_quality.Web.Application.Services.Cities.Queries;
using api_air_quality.Web.Application.Services.Countries.Queries;
using api_air_quality.Web.Application.Services.Country.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Common
{
    public interface IApiService
    {
        Task<Domain.Models.Countries> GetAllCountriesAsync(GetAllCountriesQuery query);
        Task<Domain.Models.Rootobject> GetCitiesByCountryCodeAsync(GetCitiesByCountryQuery query);

    }
}
