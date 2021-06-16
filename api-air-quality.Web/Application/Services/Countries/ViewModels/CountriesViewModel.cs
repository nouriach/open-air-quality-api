using api_air_quality.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services.Countries.ViewModels
{
    public class CountriesViewModel
    {
        public CountriesViewModel(Rootobject result)
        {
            Countries = AddCountries(result.results);
        }

        private IEnumerable<string> AddCountries(Result[] results)
        {
            Countries = new List<string>();
            List<string> names = new List<string>();

            foreach(var country in results)
            {
                names.Add(country.name);
            }
            return names;
        }

        public IEnumerable<string> Countries { get; set; }
    }
}
