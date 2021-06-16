using api_air_quality.Web.Application.Services.Countries.ViewModels;
using api_air_quality.Web.Domain.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Rootobject content = new Rootobject()
            {
                results = new Result[]
                {
                    new Result
                    {
                        name = "Lorum",
                    },
                    new Result
                    {
                        name = "Ipsum"
                    },
                    new Result
                    {
                        name = "Mori"
                    }
                }
            };

            //Act
            CountriesViewModel vm = new CountriesViewModel(content);

            //Assert
            var expected = content.results;
            var actual = vm.Countries;

            Assert.AreEqual(expected.Length, actual.Count()); 
        }
    }
}
