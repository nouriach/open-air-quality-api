using api_air_quality.Web.Application.Common;
using api_air_quality.Web.Application.Services.Countries.Handlers;
using api_air_quality.Web.Application.Services.Countries.Queries;
using api_air_quality.Web.Domain.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace api_air_quality.Web.Tests.ApplicationTests.ServicesTests.CountriesTests.HandlersTests
{
    class WhenUsingGetAllCountriesQueryHandler
    {

        //Arrange
        //Act
        //Assert

        [Test]
        public async Task QueryHandle_ReceivesQuery_ThenReturnsCorrectObject()
        {
            //Arrange
            Mock<IApiService> service = new Mock<IApiService>();
            GetAllCountriesQuery query = new GetAllCountriesQuery();
            Rootobject countries = new Rootobject();
            service.Setup(sut => sut.GetAllCountriesAsync(query)).ReturnsAsync(countries);

            //Act
            GetAllCountriesQueryHandler handler = new GetAllCountriesQueryHandler(service.Object);
            var expected = countries;
            var actual = await handler.Handle(query, CancellationToken.None);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
