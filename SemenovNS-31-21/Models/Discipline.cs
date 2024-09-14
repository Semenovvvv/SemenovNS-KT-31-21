namespace SemenovNS_31_21.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Mark> Marks { get; set; }
        public ICollection<Test> Tests { get; set; }
    }
}