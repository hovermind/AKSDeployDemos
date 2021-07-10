using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace API.Foo.Controllers
{

    [Route("~/")]
    public class HomeController : FooBaseApiController
    {
        [HttpGet("~/")]
        public string Index()
        {
            return $@"{{ ""scope"" : ""{ Assembly.GetAssembly(GetType()).GetName().Name}"", ""controller-name"" : ""{GetType().Name}"", ""method-name"" : ""{MethodBase.GetCurrentMethod().Name}"" }}";
        }
    }
}
