using api_air_quality.Web.Application.Services.Cities.Queries;
using FluentValidation;


namespace api_air_quality.Web.Application.Services.Cities.Validators
{
    public class GetCitiesByCountryQueryValidator : AbstractValidator<GetCitiesByCountryQuery>
    {
        public GetCitiesByCountryQueryValidator()
        {
            RuleFor(q => q.CountryCode).NotEmpty().Length(2,2);
        }
    }
}
