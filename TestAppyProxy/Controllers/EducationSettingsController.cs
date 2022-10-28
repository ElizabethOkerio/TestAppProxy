using System.Web.Http;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using TestAppyProxy.Models;

namespace TestAppyProxy.Controllers
{
    public class EducationSettingsController : ODataController
    {
        [EnableQuery]
        public IHttpActionResult Get()
        {
            var settings = DataSource.GetEducationSettings();
            return Ok(settings);
        }

        [HttpPatch]
        [ODataRoute("EducationSettings/{id}")]
        public IHttpActionResult UpdateSettings([FromBody] Delta<EducationSettings> delta)
        {
            return Ok();
        }
    }
}
