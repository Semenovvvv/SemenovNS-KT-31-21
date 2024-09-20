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

        public async Task<ICollection<Student>> GetStudentsAsync()
        {
            var student = await _dbContext.Students.ToListAsync();
            return student;
        }

        public async Task<ICollection<Student>> GetStudentsByGroupNameAsync(string groupName)
        {
            var students = await _dbContext.Students.Where(g => g.Group.Name == groupName).ToListAsync();
            return students;
        }

        public async Task<Student> AddStudentAsync(CreateStudentDto dto)
        {
            var student = new Student
            {
                Surname = dto.Surname,
                Name = dto.Name,
                Patronymic = dto.Patronymic,
                Age = dto.Age,
                GroupId = dto.GroupId,
            };
            await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();

            return student;
        }

        public async Task<bool> DeleteStudentAsync(int id)
        {
            var student = await _dbContext.Students.FindAsync(id);

            if (student == null)
            {
                return false;
            }
            _dbContext.Remove(student);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateStudentAsync(int id, UpdateStudentDto dto)
        {
            var student = await _dbContext.Students.FindAsync(id);

            if (student == null)
            {
                return false;
            }

            student.Surname = dto.Surname;
            student.Name = dto.Name;
            student.Patronymic = dto.Patronymic;
            student.Age = dto.Age;
            student.GroupId = dto.GroupId;

            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
