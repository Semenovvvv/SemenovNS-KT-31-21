using Microsoft.EntityFrameworkCore;
using SemenovNS_31_21.Database;
using SemenovNS_31_21.DTO.Student;
using SemenovNS_31_21.Interfaces;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _dbContext;

        public StudentService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Student>> GetStudents()
        {
            return await _dbContext.Students.ToListAsync();
        }

        public async Task<Student> AddStudent(CreateStudentDto dto)
        {
            var student = new Student
            {
                Surname = dto.surname,
                Name = dto.name,
                Patronymic = dto.patronymic,
                Age = dto.age,
                GroupId = dto.groupId,
            };
            await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();

            return student;
        }

        public async Task DeleteStudent(int id)
        {
            var student = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            _dbContext.Remove(student);
        }

        public Task EditStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _dbContext.Students
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
