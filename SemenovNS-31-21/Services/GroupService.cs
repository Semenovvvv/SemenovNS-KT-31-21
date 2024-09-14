using Microsoft.EntityFrameworkCore;
using SemenovNS_31_21.Database;
using SemenovNS_31_21.Interfaces;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Services
{
    public class GroupService : IGroupService
    {
        private readonly StudentDbContext _dbContext;

        public GroupService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddGroupAsync(string name)
        {
            if (await _dbContext.Groups.FirstOrDefaultAsync(x => x.Name == name) != null)
            {
                return false;
            }

            var group = new Group { Name = name };
            await _dbContext.Groups.AddAsync(group);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteGroupAsync(int id)
        {
            var group = await _dbContext.Groups.FindAsync(id);

            if (group == null)
                return false;

            _dbContext.Groups.Remove(group);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateGroupAsync(int id, string name)
        {
            var group = await _dbContext.Groups.FindAsync(id);

            if (group == null)
            {
                return false;
            }

            group.Name = name;
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Group> GetGroupByIdAsync(int id)
        {
            var group = await _dbContext.Groups
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.Id == id);

            return group;
        }

        public async Task<Group> GetGroupByNameAsync(string name)
        {
            var group =  await _dbContext.Groups
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.Name == name);

            return group;
        }

        public async Task<List<Group>> GetGroupsAsync()
        {
            return await _dbContext.Groups
                .AsNoTracking()
                .ToListAsync() ?? new List<Group>();
        }
    }
}
