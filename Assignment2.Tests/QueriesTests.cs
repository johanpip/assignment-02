namespace Assignment2.Tests;
using FluentAssertions;
using Xunit;

public class QueriesTests
{
    [Fact]
    public void Query1()
    {
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var result = Queries.Query1(wizards);

        //Assert
        result.Should().BeEquivalentTo(new[] { "Harry Potter", "Ron Weasley", "Hermione Granger", "Albus Dumbledore", "Lord Voldemort", "Draco Malfoy" });
    }

    [Fact]
    public void Query2()
    {
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var result = Queries.Query2(wizards);

        //Assert
        result.Should().Be(1977);
    }

    [Fact]
    public void Query3()
    {
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var result = Queries.Query3(wizards);

        //Assert
        result.Should().BeEquivalentTo(new[] { ("Harry Potter", 1997), ("Ron Weasley", 1998), ("Hermione Granger", 1999), ("Albus Dumbledore", 2000), ("Lord Voldemort", 2001), ("Draco Malfoy", 2002) });
    }

    [Fact]
    public void Query4()
    {
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var result = Queries.Query4(wizards);

        //Assert
        result.Should().BeEquivalentTo(new[]
        {
            ("J.R.R. Tolkien", new[] {"Sauron"}),
            ("J.K. Rowling", new[] {"Harry Potter", "Ron Weasley", "Hermione Granger", "Albus Dumbledore", "Lord Voldemort", "Draco Malfoy"}),
            ("George Lucas", new[] {"Darth Vader", "Darth Maul", "Darth Sidious"})
        });
    }

    [Fact]
    public void Query1LINQ()
    {
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var result = Queries.Query1LINQ(wizards);

        //Assert
        result.Should().BeEquivalentTo(new[] { "Harry Potter", "Ron Weasley", "Hermione Granger", "Albus Dumbledore", "Lord Voldemort", "Draco Malfoy" });
    }

    [Fact]
    public void Query2LINQ()
    {
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var result = Queries.Query2LINQ(wizards);

        //Assert
        result.Should().Be(1977);
    }

    [Fact]
    public void Query3LINQ()
    {
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var result = Queries.Query3LINQ(wizards);

        //Assert
        result.Should().BeEquivalentTo(new[] { ("Harry Potter", 1997), ("Ron Weasley", 1998), ("Hermione Granger", 1999), ("Albus Dumbledore", 2000), ("Lord Voldemort", 2001), ("Draco Malfoy", 2002) });
    }

    [Fact]
    public void Query4LINQ()
    {
        //Arrange
        var wizards = WizardCollection.Create();

        //Act
        var result = Queries.Query4LINQ(wizards);

        //Assert
        result.Should().BeEquivalentTo(new[]
        {
            ("J.R.R. Tolkien", new[] {"Sauron"}),
            ("J.K. Rowling", new[] {"Harry Potter", "Ron Weasley", "Hermione Granger", "Albus Dumbledore", "Lord Voldemort", "Draco Malfoy"}),
            ("George Lucas", new[] {"Darth Vader", "Darth Maul", "Darth Sidious"})
        });
    }
}
