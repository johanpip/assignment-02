using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Assignment2.Tests
{
    public class DelegatesAndAnonymousMethodstests
    {

        [Fact]
        public void ReverseString()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var classs = new DelegatesAndAnonymousMethods();
            classs.WriteLineReverse("Hakunamatata");

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            output.Should().Be("atatamanukaH");
        }

        [Fact]
        public void ReverseString_withManyWords()
        {
            //Arrange
            using var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            var classs = new DelegatesAndAnonymousMethods();
            classs.WriteLineReverse("The Sorting hat is antivax");

            //Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            output.Should().Be("xavitna si tah gnitroS ehT");
        }

        [Fact]
        public void getProductOfTwoNumbers()
        {
            //Arrange
            var main = new DelegatesAndAnonymousMethods();

            //Act
            var result = main.GetProduct(12.67, 14.668);

            //Assert
            result.Should().Be(185.84356);
        }

        [Fact]
        public void getProductOfTwoNumbersButOneIsNegative()
        {
            //Arrange
            var main = new DelegatesAndAnonymousMethods();

            //Act
            var result = main.GetProduct(12.67, -14.668);

            //Assert
            result.Should().Be(-185.84356);
        }

        [Fact]
        public void getProductOfTwoNumbersButTheyAreBothNegative()
        {
            //Arrange
            var main = new DelegatesAndAnonymousMethods();

            //Act
            var result = main.GetProduct(-12.67, -14.668);

            //Assert
            result.Should().Be(185.84356);
        }

        [Fact]
        public void CheckIfStringEqualToInt()
        {
            //Arrange
            var main = new DelegatesAndAnonymousMethods();

            //Act
            var result = main.isItEqual("42000", 42000);

            //Assert
            result.Should().Be(true);
        }

        [Fact]
        public void CheckIfStringEqualToInt2()
        {
            //Arrange
            var main = new DelegatesAndAnonymousMethods();

            //Act
            var result = main.isItEqual("420000", 42000);

            //Assert
            result.Should().Be(false);
        }

        [Fact]
        public void CheckIfStringEqualToInt3()
        {
            //Arrange
            var main = new DelegatesAndAnonymousMethods();

            //Act
            var result = main.isItEqual(" 42000", 0);

            //Assert
            result.Should().Be(false);
            //false IS exspected as AllowThousands is not implemented.
        }
    }
}
