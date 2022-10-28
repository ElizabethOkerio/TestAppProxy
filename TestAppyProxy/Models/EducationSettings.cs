using System.Collections.Generic;

namespace TestAppyProxy.Models
{
    public class EducationSettings
    {
        public int Id { get; set; }
        public bool SubmissionAnimationDisabled { get; set; }

        public IEnumerable<EducationGradingCategory> GradingCategories { get; set; }
    }
}