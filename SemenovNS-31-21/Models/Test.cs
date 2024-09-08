namespace SemenovNS_31_21.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public int StudentId {  get; set; }
        public Student Student { get; set; }
        public int DisciplineId { get; set; }
        public Disciplince Disciplince { get; set; }
    }
}