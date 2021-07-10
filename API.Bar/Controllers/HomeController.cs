using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace API.Bar.Controllers
{
    [Route("~/")]
    public class HomeController : BarBaseApiController
    {
        [HttpGet("~/")]
        public string Index()
        {
            return $@"{{ ""scope"" : ""{ Assembly.GetAssembly(GetType()).GetName().Name}"", ""controller-name"" : ""{GetType().Name}"", ""method-name"" : ""{MethodBase.GetCurrentMethod().Name}"" }}";
        }
    }
}
