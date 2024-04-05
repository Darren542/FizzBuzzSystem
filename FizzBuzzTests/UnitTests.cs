using FizzBuzzLibrary;

namespace FizzBuzzTests;

public class UnitTests
{
    [Fact]
    public void Given1Output1()
    {
        // Arrange
        var fizzBuzzLogic = new FizzBuzzLogic();

        // Act
        string? result = fizzBuzzLogic.GetFizzBuzz(1);

        // Expected: "1 "
        string? expected = "1 ";

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Given3Output12Fizz()
    {
        // Arrange
        var fizzBuzzLogic = new FizzBuzzLogic();

        // Act
        string? result = fizzBuzzLogic.GetFizzBuzz(3);

        // Expected: "1 2 Fizz "
        string? expected = "1 2 Fizz ";

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Given5Output12Fizz4Buzz()
    {
        // Arrange
        var fizzBuzzLogic = new FizzBuzzLogic();

        // Act
        string? result = fizzBuzzLogic.GetFizzBuzz(5);

        // Expected: "1 2 Fizz 4 Buzz "
        string? expected = "1 2 Fizz 4 Buzz ";

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Given15OutputFizzBuzz()
    {
        // Arrange
        var fizzBuzzLogic = new FizzBuzzLogic();

        // Act
        string? result = fizzBuzzLogic.GetFizzBuzz(15);

        // Expected: "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz "
        string? expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ";

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GivenNeg1ThrowException()
    {
        // Arrange
        var fizzBuzzLogic = new FizzBuzzLogic();

        // Act
        Action act = () => fizzBuzzLogic.GetFizzBuzz(-1);

        // Assert
        Assert.Throws<Exception>(act);
    }

    [Fact]
    public void GivenGreaterThan100OutputException()
    {
        // Arrange
        var fizzBuzzLogic = new FizzBuzzLogic();

        // Act
        Action act = () => fizzBuzzLogic.GetFizzBuzz(101);

        // Assert
        Assert.Throws<Exception>(act);
    }

    [Fact]
    public void Given0OutputEmpty()
    {
       // Arrange
        var fizzBuzzLogic = new FizzBuzzLogic();

        // Act
        string? result = fizzBuzzLogic.GetFizzBuzz(0);

        // Expected: ""
        string? expected = "";

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GivenNullOutputThrowsException()
    {
        // Arrange
        var fizzBuzzLogic = new FizzBuzzLogic();

        // Act
        Action act = () => fizzBuzzLogic.GetFizzBuzz(null);

        // Assert
        Assert.Throws<Exception>(act);
    }
}