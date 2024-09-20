using SemenovNS_31_21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemenovNS_31_21.Tests
{
    public class GroupTests
    {
        [Fact]
        public void IsValidGroupName_KT3120_True()
        {
            var group = new Group
            {
                Name = "КТ-31-21"
            };

            var result = group.IsValidGroupName();

            Assert.True(result);
        }
    }
}
