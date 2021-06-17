using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.Cities.Queries;
using api_air_quality.Web.Application.Services.Countries.Queries;
using api_air_quality.Web.Domain.Models;
using api_air_quality.Web.Infrastructure.Services;
using NUnit.Framework;
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
            Countries expected = new Countries();
            
            //Act
            var actual = await service.GetAllCountriesAsync(query);

            //Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [Test]
        public async Task ThenGetAllCitiesByCountry_WithCountryCode_ReturnCorrectObject()
        {
            //Arrange
            IApiService service = new ApiService();
            GetCitiesByCountryQuery query = new GetCitiesByCountryQuery() { CountryCode = "AD" };
            Cities expected = new Cities();

            //Act
            var actual = await service.GetCitiesByCountryCodeAsync(query);

            //Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
