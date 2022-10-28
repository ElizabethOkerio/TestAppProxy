using System.Collections.Generic;

namespace TestAppyProxy.Models
{
    public class DataSource
    {
        private static IList<EducationSettings> _settings { get; set; }

        public static IList<EducationSettings> GetEducationSettings()
        {
            if (_settings != null)
            {
                return _settings;
            }

            _settings = new List<EducationSettings>();

            // book #1
            EducationSettings seta = new EducationSettings
            {
                Id = 1,
                SubmissionAnimationDisabled = true,

                GradingCategories = new List<EducationGradingCategory>
                {
                    new EducationGradingCategory
                    {
                        Id = 1,
                        DisplayName = "disa",
                        PercentageWeight = 98,
                        AllowedOrigins = new string[] {"*"},
                        AllowedHeaders = new string[] {"*"},
                        AllowedMethods = new string[] {"*"}
                    },
                                      new EducationGradingCategory
                    {
                        Id = 1,
                        DisplayName = "dis7",
                        PercentageWeight = 97,
                        AllowedOrigins = new string[] {"*"},
                        AllowedHeaders = new string[] {"*"},
                        AllowedMethods = new string[] {"*"}
                    },

                }
            };
            _settings.Add(seta);

            // settings #2
            EducationSettings setb = new EducationSettings
            {
                Id = 2,
                SubmissionAnimationDisabled = false,

                GradingCategories = new List<EducationGradingCategory>
                {
                    new EducationGradingCategory
                    {
                        Id = 1,
                        DisplayName = "disa",
                        PercentageWeight = 98,
                        AllowedOrigins = new string[] {"*"},
                        AllowedHeaders = new string[] {"*"},
                        AllowedMethods = new string[] {"*"}
                    },
                                      new EducationGradingCategory
                    {
                        Id = 1,
                        DisplayName = "dis7",
                        PercentageWeight = 97,
                        AllowedOrigins = new string[] {"*"},
                        AllowedHeaders = new string[] {"*"},
                        AllowedMethods = new string[] {"*"}
                    },

                }
            };

            _settings.Add(setb);
            return _settings;
        }
    }
}