using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeAPI : ControllerBase
    {
       // public ILogger employeeLogger;
        public EmployeeAPI()
        {
         //   employeeLogger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Get()
        {
            Log.Logger.Information("retrived employee list");
            return Ok(EmployeeRepository.lstEmployees);
        }

        [HttpGet]
        [Route("{employeeId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Employee> Get(int employeeId)
        {
            if (employeeId <=0 )
            {
                Log.Logger.Error("Invalid employee Id.");
                return BadRequest();
            }

            var objEmployee = EmployeeRepository.lstEmployees.Where(x=> x.Id == employeeId).FirstOrDefault();
            if (objEmployee == null)
            {
                Log.Logger.Warning("Employee id not available.");
                return NotFound();
            }

            return Ok(objEmployee);
        }
    }
}