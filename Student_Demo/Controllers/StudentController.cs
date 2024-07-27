using Microsoft.AspNetCore.Mvc;
using Student_Demo.Models;

namespace Student_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAll()
        {
            //   Thread.Sleep(9000);
            var students = new List<Student>()
            {
                new Student { Id = 1, Name = "mostafa", DepartmentId = 1 },
                new Student { Id = 2, Name = "omar", DepartmentId = 2 },
                new Student { Id = 3, Name = "ali", DepartmentId = 1 },
                new Student { Id = 4, Name = "mahmoud", DepartmentId = 2 }

            };

            return Ok(students);
        }
    }
}
