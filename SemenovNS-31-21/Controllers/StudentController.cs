﻿using Microsoft.AspNetCore.Mvc;
using SemenovNS_31_21.DTO.Student;
using SemenovNS_31_21.Interfaces;

namespace SemenovNS_31_21.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<GroupController> _logger;
        private readonly IStudentService _studentService;

        public StudentController(ILogger<GroupController> logger, IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        [HttpGet("GetStudents")]
        public async Task<IActionResult> GetGroups()
        {
            var students = await _studentService.GetStudentsAsync();
            return Ok(students);
        }

        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent(CreateStudentDto dto)
        {
            var student = await _studentService.AddStudentAsync(dto);
            return Ok(student);
        }

        [HttpPut("UpdateStudent/{id}")]
        public async Task<IActionResult> UpdateStudent(int id, [FromBody] UpdateStudentDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name) || string.IsNullOrWhiteSpace(dto.Surname) || dto.Age <= 0 || dto.GroupId <= 0)
            {
                return BadRequest(new { Success = false, Message = "Некорректные данные" });
            }

            var result = await _studentService.UpdateStudentAsync(id, dto);

            if (!result)
            {
                return NotFound(new { Success = false, Message = "Студент не найден" });
            }

            return Ok(new { Success = true, Message = "Студент успешно обновлен" });
        }
    }
}
