using api_air_quality.Web.Application.Services.Countries.ViewModels;
using api_air_quality.Web.Domain.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    },
                    new Country
                    {
                        name = "Ipsum"
                    },
                    new Country
                    {
                        name = "Mori"
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
    }
}
