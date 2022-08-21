using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        public static List<Student> students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Paika",
                FirstName = "Phong",
                LastName = "Sherwin",
                Place = "New York City"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAll()
        {
            return Ok(students);
        }
    }
}
