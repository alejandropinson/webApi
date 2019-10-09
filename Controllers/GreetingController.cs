using Microsoft.AspNetCore.Mvc;

namespace webAPIStarter.Controllers
    {
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase
    {
        [HttpGet]
        public string Get() {
            return "Hello from .NET Core!";
        }
    }
}