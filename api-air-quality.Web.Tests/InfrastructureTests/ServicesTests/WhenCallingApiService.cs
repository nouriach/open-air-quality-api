using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.AirQuality.Queries;
using api_air_quality.Web.Application.Services.Cities.Queries;
using api_air_quality.Web.Application.Services.Countries.Queries;
using api_air_quality.Web.Domain.Models;
using api_air_quality.Web.Infrastructure.Services;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace api_air_quality.Web.Tests.InfrastructureTests.ServicesTests
{
    [TestFixture]
    public class WhenCallingApiService
    {
        //Arrange
        //Act
        //Assert
        private HttpClient _httpClient;

        public void TestSetup()
        {

            _httpClient = new HttpClient();
        }

        [Test]
        public async Task ThenGetAllCountries_WithNoQueryParams_ReturnCorrectObject()
        {
            //Arrange
            TestSetup();
            IApiService service = new ApiService(_httpClient);
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
            TestSetup();
            IApiService service = new ApiService(_httpClient);
            GetCitiesByCountryQuery query = new GetCitiesByCountryQuery() { CountryCode = "AD" };
            Cities expected = new Cities();

            //Act
            var actual = await service.GetCitiesByCountryCodeAsync(query);

            //Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [Test]
        [TestCase("US", "Akron")]
        [TestCase("US", "BERNALILLO")]
        [TestCase("US", "BIG HORN")]

        public async Task ThenGetAirQualityForCity_WithCountryCodeAndCity_ReturnCorrectObect(string country, string city)
        {
            //Arrange
            TestSetup();
            IApiService service = new ApiService(_httpClient);
            GetAirQualityForCityQuery query = new GetAirQualityForCityQuery()
            {
                CityName = city,
                CountryCode = country
            };
            AirQuality expected = new AirQuality();

            //Act
            var actual = await service.GetAirQualityForCityAsync(query);

            //Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());

        }
    }
}
