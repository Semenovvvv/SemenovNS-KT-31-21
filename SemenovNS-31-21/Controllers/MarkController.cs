using Microsoft.AspNetCore.Mvc;
using SemenovNS_31_21.DTO.Marks;
using SemenovNS_31_21.Interfaces;
using SemenovNS_31_21.Services;

namespace SemenovNS_31_21.Controllers
{
    public class MarkController : Controller
    {
        private readonly ILogger<MarkController> _logger;
        private readonly IMarkService _markService;

        public MarkController(ILogger<MarkController> logger, IMarkService markService)
        {
            _logger = logger;
            _markService = markService;
        }

        [HttpPost("AddMark")]
        public async Task<IActionResult> AddMark([FromBody] MarkDto dto)
        {
            if (dto.Result < 2 || dto.Result > 5 || dto.StudentId <= 0 || dto.DisciplineId <= 0)
            {
                return BadRequest(new { Success = false, Message = "Некорректные данные" });
            }

            var result = await _markService.AddMarkAsync(dto);

            if (!result)
            {
                return NotFound(new { Success = false, Message = "Студент или дисциплина не найдены" });
            }

            return Ok(new { Success = true, Message = "Оценка успешно добавлена" });
        }

        [HttpPut("UpdateMark/{id}")]
        public async Task<IActionResult> UpdateMark(int id, [FromBody] MarkDto dto)
        {
            if (dto.Result < 2 || dto.Result > 5 || dto.StudentId <= 0 || dto.DisciplineId <= 0)
            {
                return BadRequest(new { Success = false, Message = "Некорректные данные" });
            }

            var result = await _markService.UpdateMarkAsync(id, dto);

            if (!result)
            {
                return NotFound(new { Success = false, Message = "Оценка не найдена" });
            }

            return Ok(new { Success = true, Message = "Оценка успешно обновлена" });
        }
    }
}
