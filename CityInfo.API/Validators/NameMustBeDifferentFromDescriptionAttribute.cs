using CityInfo.API.Models;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Validators
{
    public class NameMustBeDifferentFromDescriptionAttribute
        : ValidationAttribute
    {
        public NameMustBeDifferentFromDescriptionAttribute()
        {
        }

        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            if (validationContext.ObjectInstance is not PointOfInterestForUpsertDto poi) 
            {
                throw new InvalidOperationException(
                    $"Attribute {nameof(NameMustBeDifferentFromDescriptionAttribute)} " +
                    $"must be applied to a {nameof(PointOfInterestForUpsertDto)} " +
                    $"or a derived type.");
            }

            if (poi.Name.Equals(poi.Description, StringComparison.OrdinalIgnoreCase))
            {
                return new ValidationResult(
                    "The name should be different from the description",
                    new[] { nameof(PointOfInterestForUpsertDto) });
            }

            return ValidationResult.Success;
        }
    }
}
