using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.Countries.Queries;
using api_air_quality.Web.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace api_air_quality.Web.Infrastructure.Services
{
    public class ApiService : IApiService
    {
        // https://u50g7n0cbj.execute-api.us-east-1.amazonaws.com/v2/countries

        public async Task<Rootobject> GetAllCountriesAsync(GetAllCountriesQuery query)
        {
            HttpClient client = new HttpClient();
            var content = await client.GetStringAsync("https://u50g7n0cbj.execute-api.us-east-1.amazonaws.com/v2/countries");
            var countries = JsonConvert.DeserializeObject<Rootobject>(content);
            return countries;
        }
    }
}
