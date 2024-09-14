using Microsoft.AspNetCore.Mvc;
using SemenovNS_31_21.DTO.Groups;
using SemenovNS_31_21.Interfaces;

namespace SemenovNS_31_21.Controllers
{
    public class GroupController : Controller
    {
        private readonly ILogger<GroupController> _logger;
        private readonly IGroupService _groupsService;

        public GroupController(ILogger<GroupController> logger, IGroupService groupsService)
        {
            _logger = logger;
            _groupsService = groupsService;
        }

        [HttpGet("GetGroups")]
        public async Task<IActionResult> GetGroups()
        {
            var groups = await _groupsService.GetGroupsAsync();
            return Ok(groups);
        }

        [HttpPost("AddGroup")]
        public async Task<IActionResult> AddGroup(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest(new { Success = false, Message = "Имя группы не может быть пустым" });
            }

            var result = await _groupsService.AddGroupAsync(name);

            if (!result)
            {
                return Conflict(new { Success = false, Message = "Группа с таким именем уже существует" });
            }
            return Ok(new { Success = true, Message = "Группа успешно добавлена" });
        }

        //[HttpGet("GetGroupById")]
        //public async Task<IActionResult> GetGroupById(int id)
        //{
        //    var response = await _groupsService.GetGroupById(id);
        //    if (response != null)
        //        return Ok(response);
        //    return Ok(new { Success = false, Message = "Группа студента не найдена" });
        //}

        //[HttpGet("GetGroupByName")]
        //public async Task<IActionResult> GetGroupByName(string name)
        //{
        //    var response = await _groupsService.GetGroupByName(name);
        //    return Ok(response);
        //    if (response != null)
        //        return Ok(response);
        //    return Ok(new { Success = false, Message = "Группа студента не найдена" });
        //}

        [HttpPut("UpdateGroup/{id}")]
        public async Task<IActionResult> UpdateGroup(int id, [FromBody] UpdateGroupDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
            {
                return BadRequest(new { Success = false, Message = "Имя группы не может быть пустым" });
            }

            var result = await _groupsService.UpdateGroupAsync(id, dto.Name);

            if (result == null)
            {
                return NotFound(new { Success = false, Message = "Группа не найдена" });
            }
            return Ok(new { Success = true, Message = "Группа успешно обновлена" });
        }

        [HttpDelete("DeleteGroup")]
        public async Task<IActionResult> DeleteGroup(int id)
        {
            try
            {
                var result = await _groupsService.DeleteGroupAsync(id);
                if (result)
                {
                    return Ok(new { Success = true, Message = "Группа удалена" });
                }
                return NotFound(new { Success = false, Message = "Группа не найдена" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Success = false, Message = "Произошла ошибка при удалении группы", Error = ex.Message });
            }
        }
    }
}
