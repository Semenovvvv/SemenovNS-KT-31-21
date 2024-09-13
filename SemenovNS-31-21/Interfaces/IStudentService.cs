using SemenovNS_31_21.DTO.Student;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Interfaces
{
    public interface IStudentService
    {
        public Task<ICollection<Student>> GetStudents();
        public Task<Student> GetStudentById(int id);
        public Task<Student> AddStudent(CreateStudentDto dto);
        public Task EditStudent(int id);
        public Task DeleteStudent(int id);
    }
}
