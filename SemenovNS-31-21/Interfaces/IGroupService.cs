using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Interfaces
{
    public interface IGroupService
    {
        public Task AddGroup(string name);

        public Task DeleteGroup(int id);

        public Task<Group> EditGroup(int id, string newName);

        public Task<Group> GetGroupById(int id);

        public Task<Group> GetGroupByName(string name);

        public Task<List<Group>> GetGroups();
    }
}
