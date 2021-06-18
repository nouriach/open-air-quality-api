using api_air_quality.Web.Application.Services.AirQuality.ViewModels;
using api_air_quality.Web.Domain.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static api_air_quality.Web.Domain.Models.AirQuality;

namespace api_air_quality.Web.Tests.ApplicationTests.ServicesTests.AirQualityTests.ViewModelsTests
{
    public class WhenInstantiatingAirQualityViewModel
    {
        // arrange
        // act
        // assert

        [Test]
        public static void AirQualityiewModel_WithAirQualityModel_SetProperties()
        {
            // arrange
            AirQuality airQuality = new AirQuality
            {
                results = new AirQualityInfo[]
                {
                    new AirQualityInfo
                    {
                        location = "XXX Town",
                        city = "XXX City",
                        country = "XXXland",
                        measurements = new Measurement[]
                        {
                            new Measurement
                            {
                                parameter = "co",
                                value = "0",
                                lastUpdated = DateTime.Now,
                                unit = "ppm"                           
                            },
                            new Measurement
                            {
                                parameter = "o3",
                                value = "0.066",
                                lastUpdated = DateTime.Now,
                                unit = "ppm"
                            },
                        }
                    },
                    new AirQualityInfo
                    {
                        location = "YYY Town",
                        city = "YYY City",
                        country = "YYYland",
                        measurements = new Measurement[]
                        {
                            new Measurement
                            {
                                parameter = "pm25",
                                value = "8",
                                lastUpdated = DateTime.Now,
                                unit = "µg/m³"
                            },
                            new Measurement
                            {
                                parameter = "so2",
                                value = "0.077",
                                lastUpdated = DateTime.Now,
                                unit = "ppm"
                            },
                        }
                    },
                }
            };

            // act
            AirQualityViewModel vm = new AirQualityViewModel(airQuality);
            var actual = vm.Results.ToList();

            // assert
            for (var i=0; i < airQuality.results.Length; i++)
            {
                Assert.AreEqual(airQuality.results[i].city, actual[i].City);
                Assert.AreEqual(airQuality.results[i].location, actual[i].Location);
                Assert.AreEqual(airQuality.results[i].country, actual[i].Country);
                Assert.AreEqual(airQuality.results[i].measurements, actual[i].Measurements);
            }
        }
    }
}
