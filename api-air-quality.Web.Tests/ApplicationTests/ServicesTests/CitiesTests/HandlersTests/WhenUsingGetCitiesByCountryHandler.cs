using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.Cities.Handlers;
using api_air_quality.Web.Application.Services.Cities.Queries;
using api_air_quality.Web.Domain.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace api_air_quality.Web.Tests.ApplicationTests.ServicesTests.CitiesTests.HandlersTests
{
    public class WhenUsingGetCitiesByCountryHandler
    {
        // arrange
        // act
        // assert

        [Test]
        public async Task QueryHandler_ReceivesQueryWithCountrCode_ThenReturnsCorrectObject()
        {
            // arrange
            Mock<IApiService> service = new Mock<IApiService>();
            GetCitiesByCountryQuery query = new GetCitiesByCountryQuery();
            query.CountryCode = "AD";
            Cities cities = new Cities();
            service.Setup(sut => sut.GetCitiesByCountryCodeAsync(query)).ReturnsAsync(cities);

            // act
            GetCitiesByCountryQueryHandler handler = new GetCitiesByCountryQueryHandler(service.Object);
            var expected = cities;
            var actual = await handler.Handle(query, CancellationToken.None);

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}
