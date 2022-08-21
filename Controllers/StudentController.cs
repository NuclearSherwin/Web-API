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
                Place = "New York City",
                Special = "Intelligence"
            },
            new Student
            {
                Id = 2,
                Name = "Spider Man",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New York City",
                Special = "Spider web"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAll()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(int id)
        {
            var student = students.Find(s => s.Id == id);
            if (student == null) return BadRequest("Student not found");
            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            students.Add(student);
            return Ok(students);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Student>>> UpdateStudent(Student studentObj)
        {
            var student = students.Find(s => s.Id == studentObj.Id);
            if (student == null) return BadRequest("Student not found");
            student.Name = studentObj.Name;
            student.FirstName = studentObj.FirstName;
            student.LastName = studentObj.LastName;
            student.Place = studentObj.Place;
            student.Special = studentObj.Special;

            return Ok(students);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Student>>> Delete(int id)
        {
            var student = students.Find(s => s.Id == id);
            if (student == null) return BadRequest("Student not found");
            students.Remove(student);

            return Ok(student);
        }
    }
}
