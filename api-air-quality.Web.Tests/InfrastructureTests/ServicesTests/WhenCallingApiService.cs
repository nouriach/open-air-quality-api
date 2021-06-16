using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.Countries.Queries;
using api_air_quality.Web.Domain.Models;
using api_air_quality.Web.Infrastructure.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_air_quality.Web.Tests.InfrastructureTests.ServicesTests
{
    public class WhenCallingApiService
    {

        //Arrange
        //Act
        //Assert

        [Test]
        public async Task ThenGetAllCountries_WithNoQueryParams_ReturnCorrectObject()
        {
            //Arrange
            IApiService service = new ApiService();
            GetAllCountriesQuery query = new GetAllCountriesQuery();
            Rootobject expected = new Rootobject();
            
            //Act
            var actual = await service.GetAllCountriesAsync(query);

            //Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
