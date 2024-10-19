using System.Text.Json.Serialization;

namespace SemenovNS_31_21.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Result { get; set; }
        [JsonIgnore]
        public Student Student { get; set; }
        public int StudentId {  get; set; }
        public int DisciplineId { get; set; }
        [JsonIgnore]
        public Discipline Discipline { get; set; }
    }
}