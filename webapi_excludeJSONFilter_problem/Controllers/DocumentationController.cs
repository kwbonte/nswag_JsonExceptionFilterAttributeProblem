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
            throw new System.Exception("this is the exception message we expect to see, if you hit f5 you will see the other exception");
        }
    }
}