using api_air_quality.Web.Application.Services.Cities.Queries;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_air_quality.Web.Tests.ApplicationTests.ServicesTests.CitiesTests.QueriesTests
{
    public class WhenSettingGetCitiesByCountryCodeQueryHandler
    {
        // Arrange
        // Act
        // Assert

        [Test]
        [TestCase("AD")]
        [TestCase("GB")]
        [TestCase("AD")]
        [TestCase("YY")]
        [TestCase("AX")]

        public void GivenCountryCode_FromClient_CountryCodePropertyIsSet(string expected)
        {
            // Arrange
            GetCitiesByCountryQuery query = new GetCitiesByCountryQuery();

            // Act
            query.CountryCode = expected;
            var actual = query.CountryCode;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
