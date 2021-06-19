using api_air_quality.Web.Application.Services.Countries.Queries;
using FluentValidation;

namespace api_air_quality.Web.Application.Services.Countries.Validators
{
    public class GetAllCountriesQueryValidator : AbstractValidator<GetAllCountriesQuery>
    {
        public GetAllCountriesQueryValidator()
        {
            //
        }
    }
}
