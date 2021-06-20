using api_air_quality.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services.Countries.ViewModels
{
    public class CountriesViewModel
    {
        public CountriesViewModel(){}
        public CountriesViewModel(Domain.Models.Countries countriesInfo)
        {
            Countries = AddCountries(countriesInfo);
        }

        private Dictionary<string, string> AddCountries(Domain.Models.Countries countriesInfo)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();

            foreach(var country in countriesInfo.Result)
            {
                names.Add(country.code, country.name);
            }
            return names;
        }

        public Dictionary<string, string> Countries { get; private set; }

    }
}
