using Microsoft.EntityFrameworkCore;
using SemenovNS_31_21.Database;
using SemenovNS_31_21.Models;
using SemenovNS_31_21.Services;

namespace SemenovNS_31_21.Tests
{
    public class StudentIntregrationTests
    {
        public readonly DbContextOptions<StudentDbContext> _dbContextOptions;

        public StudentIntregrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<StudentDbContext>()
                .UseInMemoryDatabase(databaseName: "studnet_db")
                .Options;
        }

        [Fact]
        public async Task GetStudentsByGroupAsync_KT3120_TwoObjects()
        {
            // Arrange
            var ctx = new StudentDbContext(_dbContextOptions);
            var studentService = new StudentService(ctx);
            var groups = new List<Group>
            {
                new Group
                {
                    Name = "KT-31-20"
                },
                new Group
                {
                    Name = "KT-41-20"
                }
            };
            await ctx.Set<Group>().AddRangeAsync(groups);

            var students = new List<Student>
            {
                new Student
                {
                    Surname = "qwerty",
                    Name = "asdf",
                    Patronymic = "zxc",
                    GroupId = 1,
                },
                new Student
                {
                    Surname = "qwerty2",
                    Name = "asdf2",
                    Patronymic = "zxc2",
                    GroupId = 2,
                },
                new Student
                {
                    Surname = "qwerty3",
                    Name = "asdf3",
                    Patronymic = "zxc3",
                    GroupId = 1,
                }
            };
            await ctx.Set<Student>().AddRangeAsync(students);

            await ctx.SaveChangesAsync();

            // Act
            var filter = new Filters.StudentFilters.StudentGroupFilter
            {
                GroupName = "KT-31-20"
            };

            var studentsResult = await studentService.GetStudentsByGroupNameAsync(filter.GroupName);

            // Assert
            Assert.Equal(2, studentsResult.Count);
        }
    }
}
