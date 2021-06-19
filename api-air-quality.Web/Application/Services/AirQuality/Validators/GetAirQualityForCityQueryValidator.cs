using api_air_quality.Web.Application.Services.AirQuality.Queries;
using FluentValidation;


namespace api_air_quality.Web.Application.Services.AirQuality.Validators
{
    public class GetAirQualityForCityQueryValidator : AbstractValidator<GetAirQualityForCityQuery>
    {
        public GetAirQualityForCityQueryValidator()
        {
            RuleFor(q => q.CountryCode).NotEmpty().Length(2, 2);
            RuleFor(q => q.CityName).NotEmpty();
        }
    }
}
