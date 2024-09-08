using System.Text.RegularExpressions;

namespace SemenovNS_31_21.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public List<Mark> Marks { get; set; }
        public List<Test> Tests { get; set; }
    }
}