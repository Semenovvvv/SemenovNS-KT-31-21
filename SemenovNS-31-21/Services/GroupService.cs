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

        public async Task AddGroup(string name)
        {
            var group = new Group { Name = name };
            if (_dbContext.Groups.FirstOrDefaultAsync(x => x.Name == group.Name) != null)
            {
                await _dbContext.Groups.AddAsync(group);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteGroup(int id)
        {
            var group = await GetGroupById(id);
            if (group != null)
            {
                _dbContext.Groups.Attach(group);
                _dbContext.Groups.Remove(group);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<Group> EditGroup(int id, string newName)
        {
            var group = await GetGroupById(id);
            
            if (group != null)
            {
                group.Name = newName;
                await _dbContext.SaveChangesAsync();
                return group;
            }

            throw new NullReferenceException();
        }

        public async Task<Group> GetGroupById(int id)
        {
            var group = await _dbContext.Groups
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.Id == id);

            return group;
        }

        public async Task<Group> GetGroupByName(string name)
        {
            var group =  await _dbContext.Groups
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.Name == name);

            return group;
        }

        public async Task<List<Group>> GetGroups()
        {
            return await _dbContext.Groups
                .AsNoTracking()
                .ToListAsync() ?? new List<Group>();
        }
    }
}
