using api_air_quality.Web.Application.Services.Countries.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Common
{
    public interface IApiService
    {
        Task<Domain.Models.Rootobject> GetAllCountriesAsync(GetAllCountriesQuery query);
    }
}
