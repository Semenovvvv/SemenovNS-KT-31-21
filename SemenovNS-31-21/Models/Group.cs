using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace SemenovNS_31_21.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsValidGroupName()
        {
            return Regex.Match(Name, @"/\D*-\d*-\d\d/g").Success;
        }
    }
}