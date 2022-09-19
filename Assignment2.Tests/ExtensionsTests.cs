namespace Assignment2.Tests;
using FluentAssertions;
using Xunit;

public class ExtensionsTests
{
    [Fact]
    public void IsSecure_returns_true_for_https()
    {
        //Arrange
        var uri = new Uri("https://www.google.com");

        //Act
        var result = Extensions.IsSecure(uri);

        //Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void IsSecure_returns_false_for_http()
    {
        //Arrange
        var uri = new Uri("http://www.google.com");

        //Act
        var result = Extensions.IsSecure(uri);

        //Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void WordCount_returns_1_for_one_word()
    {
        //Arrange
        var str = "Test";

        //Act
        var result = Extensions.WordCount(str);

        //Assert
        result.Should().Be(1);
    }

    [Fact]
    public void WordCount_returns_3_for_three_words()
    {
        //Arrange
        var str = "Hello World Test";

        //Act
        var result = Extensions.WordCount(str);

        //Assert
        result.Should().Be(3);
    }
}
