using System.Text.Json.Serialization;

namespace SemenovNS_31_21.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int GroupId { get; set; }
        [JsonIgnore]
        public Group Group { get; set; }
    }
}