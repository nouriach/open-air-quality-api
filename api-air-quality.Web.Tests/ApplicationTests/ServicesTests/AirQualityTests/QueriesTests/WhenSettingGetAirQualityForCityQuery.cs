using api_air_quality.Web.Application.Services.AirQuality.Queries;
using NUnit.Framework;


namespace api_air_quality.Web.Tests.ApplicationTests.ServicesTests.AirQualityTests.QueriesTests
{
    public class WhenSettingGetAirQualityForCityQuery
    {
        // Arrange
        // Act
        // Assert

        [Test]
        [TestCase("AD", "Lorum")]
        [TestCase("GB", "Ipsum")]
        [TestCase("YY", "Mori")]
        public void GivenCountryCodeAndCity_FromClient_CountryCodePropertyAndCityIsSet(string expectedCountryCode, string expectedCity)
        {
            // Arrange
            GetAirQualityForCityQuery actualQuery = new GetAirQualityForCityQuery();

            // Act
            actualQuery.CountryCode = expectedCountryCode;
            actualQuery.CityName = expectedCity;

            // Assert
            Assert.AreEqual(expectedCountryCode, actualQuery.CountryCode);
            Assert.AreEqual(expectedCity, actualQuery.CityName);
        }
    }
}
