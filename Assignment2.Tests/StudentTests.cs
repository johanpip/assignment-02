using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Assignment2.Tests
{
    public class StudentTests
    {
        //Testing ToString method
        [Fact]
        public void ToString_ReturnsStudentDetails()
        {
            //Arrange
            var student = new Student(1, "John", "Doe", new DateTime(2021, 9, 1), new DateTime(2023, 6, 30), new DateTime(2023, 6, 30));

            //Act
            var result = student.ToString();

            //Assert
            result.Should().Be("Id: 1, Name: John, Surname: Doe, Status: Active, StartDate: 01/09/2021 00.00.00, EndDate: 30/06/2023 00.00.00, GraduationDate: 30/06/2023 00.00.00");
        }


        //Testing CalculateStatus method
        [Fact]
        public void CalculateStatus_NewStudent_ReturnsNew()
        {
            //Arrange
            var student = new Student(1, "John", "Doe", new DateTime(2022, 10, 30), new DateTime(2024, 12, 31), new DateTime(2024, 12, 31));

            //Act
            var result = student.CalculateStatus();

            //Assert
            result.Should().Be(Status.New);
        }

        [Fact]
        public void CalculateStatus_ActiveStudent_ReturnsActive()
        {
            //Arrange
            var student = new Student(1, "John", "Doe", new DateTime(2021, 9, 1), new DateTime(2023, 6, 30), new DateTime(2023, 6, 30));

            //Act
            var result = student.CalculateStatus();

            //Assert
            result.Should().Be(Status.Active);
        }

        [Fact]
        public void CalculateStatus_DropoutStudent_ReturnsDropout()
        {
            //Arrange
            var student = new Student(1, "John", "Doe", new DateTime(2021, 9, 1), new DateTime(2022, 08, 22), new DateTime(2023, 12, 31));

            //Act
            var result = student.CalculateStatus();

            //Assert
            result.Should().Be(Status.Dropout);
        }

        [Fact]
        public void CalculateStatus_GraduatedStudent_ReturnsGraduated()
        {
            //Arrange
            var student = new Student(1, "John", "Doe", new DateTime(2019, 9, 1), new DateTime(2021, 6, 30), new DateTime(2021, 6, 30));

            //Act
            var result = student.CalculateStatus();

            //Assert
            result.Should().Be(Status.Graduated);
        }
    }
}


