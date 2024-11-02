using SemenovNS_31_21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemenovNS_31_21.Tests.StudentTests
{
    public class StudentUnitTests
    {
        [Fact]
        public void IsForeigner_Vladislavovich_False()
        {
            var student = new Student
            {
                Surname = "Сергеев",
                Name = "Сергей",
                Patronymic = "Владиславович"
            };

            var result = student.IsForeigner();

            Assert.False(result);
        }

        [Fact]
        public void IsForeigner_Ivanovich_False()
        {
            var student = new Student
            {
                Surname = "Сергеев",
                Name = "Сергей",
                Patronymic = "Иванович"
            };

            var result = student.IsForeigner();

            Assert.False(result);
        }

        [Fact]
        public void IsForeigner_Null_True()
        {
            var student = new Student
            {
                Surname = "Майкл",
                Name = "Джордан",
                Patronymic = null
            };

            var result = student.IsForeigner();

            Assert.True(result);
        }
    }
}
