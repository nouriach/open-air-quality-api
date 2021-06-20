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
            Assert.IsNull(query.Order);
        }

        [Test]
        [TestCase("AD", "ascending")]
        [TestCase("GB", "descending")]
        [TestCase("AD", "descending")]
        [TestCase("YY", "ascending")]
        public void GivenCountryCodeAndOrder_FromClient_CountryCodePropertyAndOrderIsSet(string expectedCountry, string expectedOrder)
        {
            // Arrange
            GetCitiesByCountryQuery actual = new GetCitiesByCountryQuery()
            {
                CountryCode = expectedCountry,
                Order = expectedOrder
            };

            // Act
            // Assert
            Assert.AreEqual(expectedCountry, actual.CountryCode);
            Assert.AreEqual(expectedOrder, actual.Order);

        }
    }
}
