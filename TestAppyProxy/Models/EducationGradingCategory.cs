using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestAppyProxy.Models
{
    public class EducationGradingCategory
    {
        public int Id { get; set; }

        public string DisplayName { get; set; }

        public int PercentageWeight { get; set; }

        [Required]
        public IEnumerable<string> AllowedOrigins { get; set; }

        [Required]
        public IEnumerable<string> AllowedHeaders { get; set; }

        [Required]
        public IEnumerable<string> AllowedMethods { get; set; }
    }
}