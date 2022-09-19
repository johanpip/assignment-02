using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Assignment2.Tests
{
    public class ImmutableStudentTests
    {
        //Testing ToString method
        [Fact]
        public void ToString_ReturnsStudentDetails()
        {
            //Arrange
            var student = new ImmutableStudent(1, "John", "Doe", new DateTime(2021, 9, 1), new DateTime(2023, 6, 30), new DateTime(2023, 6, 30));

            //Act
            var result = student.ToString();

            //Assert
            result.Should().Be("Id: 1, Name: John, Surname: Doe, Status: Active, StartDate: 01/09/2021 00.00.00, EndDate: 30/06/2023 00.00.00, GraduationDate: 30/06/2023 00.00.00");
        }
    }
}


