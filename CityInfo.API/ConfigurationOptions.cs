using System.ComponentModel.DataAnnotations;

namespace CityInfo.API
{
    public class ConfigurationOptions
    {
        public const string SectionName = "Authentication";

        [Required]
        [MinLength(32)]
        public string SecretForKey { get; set; }
        [Required]
        public string Issuer { get; set; }
    }
}
