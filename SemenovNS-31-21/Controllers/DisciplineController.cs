using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SemenovNS_31_21.DTO.Disciplines;
using SemenovNS_31_21.Interfaces;
using SemenovNS_31_21.Services;
using System.Xml.Linq;

namespace SemenovNS_31_21.Controllers
{
    public class DisciplineController : Controller
    {
        private readonly ILogger<DisciplineController> _logger;
        private readonly IDisciplineService _disciplineService;

        public DisciplineController(ILogger<DisciplineController> logger, IDisciplineService disciplineService)
        {
            _logger = logger;
            _disciplineService = disciplineService;
        }

        [HttpGet("GetDisciplines")]
        public async Task<IActionResult> GetDisciplines()
        {
            var disciplines = await _disciplineService.GetDisciplinesAsync();
            return Ok(disciplines);
        }

        [HttpPost("AddDiscipline")]
        public async Task<IActionResult> AddDiscipline([FromBody] CreateDisciplineDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
            {
                return BadRequest(new { Success = false, Message = "Имя дисциплины не может быть пустым" });
            }

            var result = await _disciplineService.AddDisciplineAsync(dto);

            if (!result)
            {
                return Conflict(new { Success = false, Message = "Дисциплина с таким именем уже существует" });
            }
            return Ok(new { Success = true, Message = "Дисциплина успешно добавлена" });
        }

        [HttpPut("UpdateDiscipline/{id}")]
        public async Task<IActionResult> UpdateDiscipline(int id, [FromBody] UpdateDisciplineDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
            {
                return BadRequest(new { Success = false, Message = "Имя дисциплины не может быть пустым" });
            }

            var result = await _disciplineService.UpdateDisciplineAsync(id, dto);

            if (result == null)
            {
                return NotFound(new { Success = false, Message = "Дисциплина не найдена" });
            }
            return Ok(new { Success = true, Message = "Дисциплина успешно обновлена" });
        }

        [HttpDelete("DeleteDiscipline")]
        public async Task<IActionResult> DeleteDiscipline(int id)
        {
            try
            {
                var result = await _disciplineService.DeleteDisciplineAsync(id);
                if (result)
                {
                    return Ok(new { Success = true, Message = "Дисциплина удалена" });
                }
                return NotFound(new { Success = false, Message = "Дисциплина не найдена" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Success = false, Message = "Произошла ошибка при удалении дисциплины", Error = ex.Message });
            }
        }
    }
}
