

using BasicAuth.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicAuth.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    // [BasicAuthenticationAttribute]
    [Authorize]
   
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "User")]
        public ActionResult<List<Employee>> GetEmployees()
        {
            var employees = Employee.GetEmployees();
            if (employees == null)
            {
                return new List<Employee>(); // Or you could return NotFound() or another appropriate response
            }
            return Ok(employees); // Return an ActionResult containing the list of employees
        }
    }
}