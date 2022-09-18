namespace Assignment2.Tests;
using FluentAssertions;
using Xunit;

public class ExtensionsTests
{
    [Fact]
    public void IsSecure_returns_true_for_https()
    {
        //arrange
        var uri = new Uri("https://www.google.com");

        //act
        var result = Extensions.IsSecure(uri);

        //assert
        result.Should().BeTrue();
    }

    [Fact]
    public void IsSecure_returns_false_for_http()
    {
        //arrange
        var uri = new Uri("http://www.google.com");

        //act
        var result = Extensions.IsSecure(uri);

        //assert
        result.Should().BeFalse();
    }

    [Fact]
    public void WordCount_returns_1_for_one_word()
    {
        //arrange
        var str = "Test";

        //act
        var result = Extensions.WordCount(str);

        //assert
        result.Should().Be(1);
    }

    [Fact]
    public void WordCount_returns_3_for_three_words()
    {
        //arrange
        var str = "Hello World Test";

        //act
        var result = Extensions.WordCount(str);

        //assert
        result.Should().Be(3);
    }
}
