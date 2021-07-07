using Microsoft.AspNetCore.Mvc;

namespace API.Bar.Controllers
{
    [ApiController]
    [Route("bar")]
    public class BarController : ControllerBase
    {
        [HttpGet("")]
        public string Index()
        {
            return "BarController.Index()";
        }

        [HttpGet("test")]
        public string Test()
        {
            return "BarController.Test()";
        }

        [HttpGet("xyz")]
        public string Xyz()
        {
            return "BarController.Xyz()";
        }
    }
}
