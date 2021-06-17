using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_air_quality.Web.Application.Services.Cities.ViewModels
{
    public class CitiesViewModel
    {
        public CitiesViewModel()
        {

        }
        public CitiesViewModel(Domain.Models.Cities cityInfo)
        {
            Cities = AddCities(cityInfo);
            Country = cityInfo.results[0].country;
        }

        private List<string> AddCities(Domain.Models.Cities cityInfo)
        {
            Cities = new List<string>();
            List<string> cities = new List<string>();

            foreach(var result in cityInfo.results)
            {
                cities.Add(result.city);
            }
            return cities;
        }

        public IEnumerable<string> Cities { get; private set; }
        public string Country { get; private set; }
        public int CitiesCount => Cities.Count();
    }
}
