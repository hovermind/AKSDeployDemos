using Microsoft.AspNetCore.Mvc;

namespace API.Foo.Controllers
{
    [ApiController]
    [Route("foo")]
    public class FooController : ControllerBase
    {
        [HttpGet("")]
        public string Index()
        {
            return "FooController.Index()";
        }

        [HttpGet("test")]
        public string Test()
        {
            return "FooController.Test()";
        }

        [HttpGet("xyz")]
        public string Xyz()
        {
            return "FooController.Xyz()";
        }
    }
}
