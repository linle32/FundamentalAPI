using FundamentalAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace FundamentalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;

        public StudentsController(ILogger<StudentsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get-all-students")]
        public IActionResult GetAll()
        {
            var students = Storage.Database.Students;
            return Ok(students);
        }

        [HttpGet]
        public IActionResult GetStudentByName([FromQuery] string name)
        {
            var students = Storage.Database.Students;
            var result = students.Where(i => i.Name.ToLower() == name.ToLower())
                .ToList();
            if (!result.Any())
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            Storage.Database.Students.Add(student);
            return Ok("Successfully created a new student");
        }

        //Ok()
        //BadRequest()
        //NotFound()
        //..


    }

    //class Service
    // Validation

}
