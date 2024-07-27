using Department_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Department_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Department>> GetAll()
        {
            var departments = new List<Department>()
            {
                new Department { Id = 1,Name="Operation"},
                new Department { Id = 2,Name="Management"}
            };
            return Ok(departments);
        }

    }
}
