using SemenovNS_31_21.DTO.Student;
using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Interfaces
{
    public interface IStudentService
    {
        public Task<Student> AddStudentAsync(CreateStudentDto dto);
        public Task<ICollection<Student>> GetStudentsByGroupNameAsync(string groupName);
        public Task<ICollection<Student>> GetStudentsAsync();
        public Task<bool> UpdateStudentAsync(int id, UpdateStudentDto dto);
        public Task<bool> DeleteStudentAsync(int id);
    }
}
