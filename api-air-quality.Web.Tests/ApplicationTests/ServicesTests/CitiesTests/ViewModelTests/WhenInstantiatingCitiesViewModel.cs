using api_air_quality.Web.Application.Services.Cities.ViewModels;
using api_air_quality.Web.Domain.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static api_air_quality.Web.Domain.Models.Cities;

namespace api_air_quality.Web.Tests.ApplicationTests.ServicesTests.CitiesTests.ViewModelTests
{
    public class WhenInstantiatingCitiesViewModel
    {
        // arrange
        // act
        // assert
        [Test]
        public static void CitiesViewModel_WithCitiesModel_SetCitiesAndCountryAndCitiesCount()
        {
            // arrange
            Cities cityInfo = new Cities()
            {
                results = new City[]
                {
                    new City
                    {
                        city = "Lorumsville",
                        country = "Lorumland"
                    },
                    new City
                    {
                        city = "Ipsumville",
                        country = "Ipsumland"
                    },
                    new City
                    {
                        city = "Moriville",
                        country = "Moriland"
                    }
                }
            };

            // act
            CitiesViewModel vm = new CitiesViewModel(cityInfo);
            var actualCities = vm.Cities.ToList();

            // assert
            Assert.AreEqual(cityInfo.results.Length, vm.CitiesCount);
            Assert.AreEqual(cityInfo.results[0].country,vm.Country);

            for (var i=0; i < cityInfo.results.Length; i++)
            {
                Assert.AreEqual(cityInfo.results[i].city, actualCities[i]);
            }
        }
    }
}
