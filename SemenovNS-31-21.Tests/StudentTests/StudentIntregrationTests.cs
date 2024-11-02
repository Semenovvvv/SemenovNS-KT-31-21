using Microsoft.EntityFrameworkCore;
using SemenovNS_31_21.Database;
using SemenovNS_31_21.Models;
using SemenovNS_31_21.Services;

namespace SemenovNS_31_21.Tests.StudentTests.StudentTests
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
        public async Task GetStudentsByGroupNameAsync_KT3118_TwoObjects()
        {
            // Arrange
            var context = new StudentDbContext(_dbContextOptions);
            var studentService = new StudentService(context);
            var groups = new List<Group>
            {
                new Group
                {
                    Name = "КТ-31-18"
                },
                new Group
                {
                    Name = "КТ-41-18"
                }
            };
            await context.Set<Group>().AddRangeAsync(groups);

            await context.SaveChangesAsync();

            var groupKT3118 = await context.Groups.FirstOrDefaultAsync(group => group.Name == "КТ-31-18");
            var groupKT4118 = await context.Groups.FirstOrDefaultAsync(group => group.Name == "КТ-41-18");

            var students = new List<Student>
            {
                new Student
                {
                    Surname = "Иванов",
                    Name = "Иван",
                    Patronymic = "Иванович",
                    GroupId = groupKT3118.Id
                },
                new Student
                {
                    Surname = "qwerty2",
                    Name = "asdf2",
                    Patronymic = "zxc2",
                    GroupId = groupKT4118.Id
                },
                new Student
                {
                    Surname = "qwerty3",
                    Name = "asdf3",
                    Patronymic = "zxc3",
                    GroupId = groupKT3118.Id
                }
            };
            await context.Students.AddRangeAsync(students);

            await context.SaveChangesAsync();

            // Act
            var filter = new Filters.StudentFilters.StudentGroupFilter
            {
                GroupName = "КТ-31-18"
            };

            var studentsResult = await studentService.GetStudentsByGroupNameAsync(filter.GroupName);

            // Assert
            Assert.Equal(2, studentsResult.Count);
        }
    }
}
