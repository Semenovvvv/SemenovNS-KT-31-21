using System.Text.RegularExpressions;

namespace SemenovNS_31_21.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public ICollection<Mark> Marks { get; set; }
        public ICollection<Test> Tests { get; set; }
    }
}