using CityInfo.API.Validators;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    [NameMustBeDifferentFromDescription]
    public class PointOfInterestForUpsertDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
