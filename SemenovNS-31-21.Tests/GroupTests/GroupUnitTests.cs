using SemenovNS_31_21.Models;

namespace SemenovNS_31_21.Tests.GroupTests
{
    public class GroupUnitTests
    {
        [Fact]
        public void IsValidGroupName_KT3121_True()
        {
            var group = new Group
            {
                Id = 1,
                Name = "КТ-31-21"
            };

            var result = group.IsValidGroupName();

            Assert.True(result);
        }
    }
}
