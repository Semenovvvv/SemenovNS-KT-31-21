using Microsoft.EntityFrameworkCore;
using SemenovNS_31_21.Database;
using SemenovNS_31_21.Models;
using SemenovNS_31_21.Services;

namespace SemenovNS_31_21.Tests.GroupTests
{
    public class GroupIntregrationTests
    {
        public readonly DbContextOptions<StudentDbContext> _dbContextOptions;

        public GroupIntregrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<StudentDbContext>()
                .UseInMemoryDatabase(databaseName: "studnet_db")
                .Options;
        }

        [Fact]
        public async Task GetGroupByNameAsync_KT3120_True()
        {
            // Arrange
            var ctx = new StudentDbContext(_dbContextOptions);
            var groupService = new GroupService(ctx);
            var groups = new List<Group>
            {
                new Group
                {
                    Name = "KT-21-20"
                },
                new Group
                {
                    Name = "KT-21-20"
                }
            };
            await ctx.Set<Group>().AddRangeAsync(groups);

            await ctx.SaveChangesAsync();

            // Act
            var filter = new Filters.StudentFilters.StudentGroupFilter
            {
                GroupName = "KT-21-20"
            };

            var groupsResult = await groupService.GetGroupByNameAsync(filter.GroupName);

            // Assert
            Assert.Equal("KT-21-20", groupsResult.Name);
        }
    }
}
