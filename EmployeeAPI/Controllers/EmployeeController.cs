using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeAPI : ControllerBase
    {
        public EmployeeAPI()
        {}

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Get()
        {
            return Ok(EmployeeRepository.lstEmployees);
        }

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Employee> Get(int employeeId)
        {
            if (employeeId <=0 )
            {
                return BadRequest();
            }

            var objEmployee = EmployeeRepository.lstEmployees.Where(x=> x.Id == employeeId).FirstOrDefault();
            if (objEmployee == null)
            {
                return NotFound();
            }

            return Ok(objEmployee);
        }
    }
}