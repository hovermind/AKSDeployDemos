using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace API.Bar.Controllers
{
    [ApiController]
    [Route("api/bar")]
    public class BarController : ControllerBase
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
