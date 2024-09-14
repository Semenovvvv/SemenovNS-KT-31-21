using Microsoft.AspNetCore.Mvc;
using SemenovNS_31_21.Interfaces;

namespace SemenovNS_31_21.Controllers
{
    public class GroupsController : Controller
    {
        private readonly ILogger<GroupsController> _logger;
        private readonly IGroupService _groupsService;

        public GroupsController(ILogger<GroupsController> logger, IGroupService groupsService)
        {
            _logger = logger;
            _groupsService = groupsService;
        }

        [HttpGet("GetGroups")]
        public async Task<IActionResult> GetGroups()
        {
            var groups = await _groupsService.GetGroups();
            return Ok(groups);
        }

        [HttpPost("AddGroup")]
        public async Task<IActionResult> AddGroup(string name)
        {
            await _groupsService.AddGroup(name);
            return Ok();
        }

        [HttpGet("GetGroupById")]
        public async Task<IActionResult> GetGroupById(int id)
        {
            var response = await _groupsService.GetGroupById(id);
            if (response != null)
                return Ok(response);
            return Ok(new { Success = false, Message = "Группа студента не найдена" });
        }

        [HttpGet("GetGroupByName")]
        public async Task<IActionResult> GetGroupByName(string name)
        {
            var response = await _groupsService.GetGroupByName(name);
            return Ok(response);
            if (response != null)
                return Ok(response);
            return Ok(new { Success = false, Message = "Группа студента не найдена" });
        }

        [HttpPut("EditGroup")]
        public async Task<IActionResult> EditGroup(int id, string newName)
        {
            var response = _groupsService.EditGroup(id, newName);
            if (response != null)
                return Ok(response);
            return Ok(new { Success = false, Message = "Группа студента не найдена" });
        }

        [HttpDelete("DeleteGroup")]
        public async Task<IActionResult> DeleteGroup(int id)
        {
            var response = (_groupsService.DeleteGroup(id));
            if (response != null) 
                return Ok(response);
            return Ok(new { Success = false, Message = "Группа не найдена" });
        }
    }
}
