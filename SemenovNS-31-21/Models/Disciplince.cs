namespace SemenovNS_31_21.Models
{
    public class Disciplince
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Mark> Marks { get; set; }
        public List<Test> Tests { get; set; }
    }
}