using Microsoft.AspNetCore.Mvc;

namespace API.Foo.Controllers
{

    [ApiController]
    public abstract class FooBaseApiController : ControllerBase
    {
        //
        // Put common functionalities only
        //
        // Do not put route attribute
        //
    }
}
