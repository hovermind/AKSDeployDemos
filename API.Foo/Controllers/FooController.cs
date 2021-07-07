using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace API.Foo.Controllers
{
    [ApiController]
    [Route("api/foo")]
    public class FooController : ControllerBase
    {
        [HttpGet("")]
        public string Index()
        {
            return $@"{{ ""controller-name"" : ""{GetType().Name}"", ""method-name"" : ""{MethodBase.GetCurrentMethod().Name}"" }}";
        }

        [HttpGet("test")]
        public string Test()
        {
            return $@"{{ ""controller-name"" : ""{GetType().Name}"", ""method-name"" : ""{MethodBase.GetCurrentMethod().Name}"" }}";
        }

        [HttpGet("xyz")]
        public string Xyz()
        {
            return $@"{{ ""controller-name"" : ""{GetType().Name}"", ""method-name"" : ""{MethodBase.GetCurrentMethod().Name}"" }}";
        }
    }
}
