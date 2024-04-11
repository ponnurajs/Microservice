using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeAPI : ControllerBase
    {
        public EmployeeAPI()
        {}

        public ActionResult Get()
        {
            return Ok();
        }
    }
}