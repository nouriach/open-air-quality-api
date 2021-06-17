using api_air_quality.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services.Countries.ViewModels
{
    public class CountriesViewModel
    {
        public CountriesViewModel(Domain.Models.Countries countriesInfo)
        {
            Countries = AddCountries(countriesInfo);
        }

        private IEnumerable<string> AddCountries(Domain.Models.Countries countriesInfo)
        {
            Countries = new List<string>();
            List<string> names = new List<string>();

            foreach(var country in countriesInfo.Result)
            {
                names.Add(country.name);
            }
            return names;
        }

        public IEnumerable<string> Countries { get; private set; }

    }
}
