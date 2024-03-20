using FundamentalAPI.Model;
using FundamentalAPI.Model.Request;
using FundamentalAPI.Service;
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

        [HttpPut("update")] 
        public IActionResult Update(int id, UpdateStudentRequest request)
        {
            var studentService = new StudentService();
          
            var updateResult = studentService.UpdateStudent(id, request);
            if (!updateResult)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var students = Storage.Database.Students;

            var student = students.FirstOrDefault(i => i.Id == id);

            if (student == null)
            {
                return NotFound($"Student Id - {id} does not exist!");
            }

            students.Remove(student);
            return Ok();
        }

        [HttpGet("good-students")]
        public IActionResult GoodStudents(int minGPA)
        {
            var studentService = new StudentService();
            var goodStudents = studentService.GetGoodStudents(minGPA);
            return Ok(goodStudents);
        }
    }

    //class Service
    // Validation\

    // Ai add product, add product nao, return list products after adding 

    // Add products to card
    // Calculate orders price
    // Check out

}
