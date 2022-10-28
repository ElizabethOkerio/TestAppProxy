using System.Web.Http;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using TestAppyProxy.Models;

namespace TestAppyProxy
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<EducationSettings>("EducationSettings");
            builder.EntitySet<EducationGradingCategory>("EducationGradingCategories");
            builder.EnableLowerCamelCase();
            config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
        }
    }
}
