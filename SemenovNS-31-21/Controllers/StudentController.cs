using Microsoft.AspNetCore.Mvc;
using SemenovNS_31_21.DTO.Student;
using SemenovNS_31_21.Interfaces;

namespace SemenovNS_31_21.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<GroupsController> _logger;
        private readonly IStudentService _studentService;

        public StudentController(ILogger<GroupsController> logger, IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        [HttpGet("GetStudents")]
        public async Task<IActionResult> GetGroups()
        {
            var students = await _studentService.GetStudents();
            return Ok(students);
        }

        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent(CreateStudentDto dto)
        {
            var student = await _studentService.AddStudent(dto);
            return Ok(student);
        }
    }
}
