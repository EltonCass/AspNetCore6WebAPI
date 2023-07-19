using CityInfo.API.Models;
using FluentValidation;

namespace CityInfo.API.Validators
{
    public class PointsOfInterestValidator : AbstractValidator<PointOfInterestForUpsertDto>
    {
        public PointsOfInterestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
                
            RuleFor(x => x.Description)
                .MinimumLength(10)
                .MaximumLength(200)
                .Must((poi, name) => !poi.Description!.Equals(name, StringComparison.OrdinalIgnoreCase))
                .WithMessage("The Description and Name should be different (FV)")
                .When(x => !string.IsNullOrEmpty(x.Description));
        }
    }
}
