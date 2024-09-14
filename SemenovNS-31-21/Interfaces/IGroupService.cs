using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Interfaces
{
    public interface IGroupService
    {
        public Task<bool> AddGroupAsync(string name);

        public Task<bool> DeleteGroupAsync(int id);

        public Task<bool> UpdateGroupAsync(int id, string newName);

        public Task<Group> GetGroupByIdAsync(int id);

        public Task<Group> GetGroupByNameAsync(string name);

        public Task<List<Group>> GetGroupsAsync();
    }
}
