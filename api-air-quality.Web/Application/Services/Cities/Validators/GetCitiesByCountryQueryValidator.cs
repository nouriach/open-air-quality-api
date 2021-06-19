using api_air_quality.Web.Application.Services.Cities.Queries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
