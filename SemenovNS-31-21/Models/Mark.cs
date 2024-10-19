using System.Text.Json.Serialization;

namespace SemenovNS_31_21.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int Result { get; set; }
        public int StudentId { get; set; }
        [JsonIgnore]
        public Student Student { get; set; }
        public int DisciplineId {  get; set; }
        [JsonIgnore]
        public Discipline Discipline { get; set; }
    }
}