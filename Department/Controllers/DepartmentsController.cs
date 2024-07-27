using Microsoft.AspNetCore.Mvc;

namespace Department.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Department>> GetAll()
        {

        }
    }
}
