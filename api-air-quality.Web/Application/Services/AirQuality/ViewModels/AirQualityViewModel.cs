

using System;
using System.Collections.Generic;
using static api_air_quality.Web.Domain.Models.AirQuality;

namespace api_air_quality.Web.Application.Services.AirQuality.ViewModels
{
    public class AirQualityViewModel
    {
        public AirQualityViewModel(Domain.Models.AirQuality airQuality)
        {
            Results = AddAirQualityData(airQuality);
        }

        public IEnumerable<AirQualityResponse> Results { get; set; }
        private IEnumerable<AirQualityResponse> AddAirQualityData(Domain.Models.AirQuality airQuality)
        {
            Results = new List<AirQualityResponse>();
            var content = new List<AirQualityResponse>();

            for(var i = 0; i < airQuality.results.Length; i++)
            {
                AirQualityResponse resp = new AirQualityResponse(airQuality.results[i]);
                content.Add(resp);
            }

            return content;
        }
    }

    public class AirQualityResponse
    {
        public AirQualityResponse(AirQualityInfo content)
        {
            Location = content.location;
            City = content.city;
            Country = content.country;
            Measurements = content.measurements;
        }
        public string Location { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public IEnumerable<Measurement> Measurements { get; set; }
    }
}
