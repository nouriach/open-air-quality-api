using api_air_quality.Web.Application.Services.Countries.ViewModels;
using api_air_quality.Web.Domain.Models;
using NUnit.Framework;
using System.Linq;
using static api_air_quality.Web.Domain.Models.Countries;

namespace api_air_quality.Web.Tests.ApplicationTests.ServicesTests.CountriesTests.ViewModelsTests
{

    public class WhenInstantiatingCountriesViewModel
    {

        //Arrange
        //Act
        //Assert

        [Test]
        public static void GivenConstructor_WithApiResponse_CountriesCollectionHasdCorrectCount()
        {
            //Arrange
            Countries content = new Countries()
            {
                Result = new Country[]
                {
                    new Country
                    {
                        name = "Lorum",
                        code = "LO"
                    },
                    new Country
                    {
                        name = "Ipsum",
                        code = "IP"
                    },
                    new Country
                    {
                        name = "Mori",
                        code = "MO"
                    }
                }
            };

            //Act
            CountriesViewModel vm = new CountriesViewModel(content);

            //Assert
            var expected = content.Result;
            var actual = vm.Countries;

            Assert.AreEqual(expected.Length, actual.Count()); 
        }

        [Test]
        public static void GivenConstructor_WithApiResponse_CountriesDictionaryIsCreated()
        {
            //Arrange
            Countries content = new Countries()
            {
                Result = new Country[]
                {
                    new Country
                    {
                        name = "Lorum",
                        code = "LO"
                    },
                    new Country
                    {
                        name = "Ipsum",
                        code = "IP"
                    },
                    new Country
                    {
                        name = "Mori",
                        code = "MO"
                    }
                }
            };

            //Act
            CountriesViewModel vm = new CountriesViewModel(content);
            var expected = content.Result;
            var actual = vm.Countries;

            // Assert
            for(var i = 0; i < expected.Length; i++)
            {
                var country = actual.Where(x => x.Key == expected[i].code).FirstOrDefault();
                Assert.AreEqual(expected[i].code, country.Key);
                Assert.AreEqual(expected[i].name, country.Value);
            }
        }
    }
}
