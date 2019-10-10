using Microsoft.AspNetCore.Mvc;

namespace webAPIStarter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Get method success";
        }

        [HttpPost]
        public string Post()
        {
            return "Post method success";
        }

        [HttpPut]
        public string Put()
        {
            return "Put method success";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Delete method success";
        }
    }
}