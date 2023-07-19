using CityInfo.API.Models;
using FluentValidation;

namespace CityInfo.API.Validators
{
    public class CityValidator : AbstractValidator<CityDto>
    {
        public CityValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description)
                .MinimumLength(10)
                .MaximumLength(200)
                .When(x => !string.IsNullOrEmpty(x.Description));
        }
    }
}
