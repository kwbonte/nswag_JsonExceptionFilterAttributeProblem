using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;


namespace webapi_excludeJSONFilter_problem.Controllers
{
    public class DocumentationController : ApiController
    {
        [HttpGet]
        public JsonResult<int[]> Get()
        {
            throw new System.Exception("custom exception message not showing up on console");
        }
    }
}