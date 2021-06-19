
using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.AirQuality.Handlers;
using api_air_quality.Web.Application.Services.AirQuality.Queries;
using api_air_quality.Web.Domain.Models;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;

namespace api_air_quality.Web.Tests.ApplicationTests.ServicesTests.AirQualityTests.HandlersTests
{
    public class WhenUsingGetAirQualityForCityQueryHandler
    {
        // arrange
        // act
        // assert

        [Test]
        public async Task QueryHandler_ReceivesQueryWithCountryCodeAndCity_ThenReturnsCorrectObject()
        {
            // arrange
            Mock<IApiService> service = new Mock<IApiService>();
            GetAirQualityForCityQuery query = new GetAirQualityForCityQuery()
            {
                CityName = "Akron",
                CountryCode = "US"
            };
            AirQuality expectedResponse = new AirQuality();
            service.Setup(sut => sut.GetAirQualityForCityAsync(query)).ReturnsAsync(expectedResponse);

            // act
            GetAirQualityForCityQueryHandler handler = new GetAirQualityForCityQueryHandler(service.Object);
            var actual = await handler.Handle(query, CancellationToken.None);

            // assert
            Assert.AreEqual(expectedResponse, actual);
        }
    }
}
