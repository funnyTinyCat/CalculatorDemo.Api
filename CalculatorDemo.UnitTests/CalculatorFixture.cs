using CalculatorDemo.Api.Models;

namespace CalculatorDemo.UnitTests;

public class CalculatorFixture
{
    [Fact]
    public void Add()
    {
        // Arrange
        var value1 = 1;
        var value2 = 2;
        var expected = 3;

        var systemUnderTest = new Calculator();

        // Act
        var actual = systemUnderTest.Add(value1, value2);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Subtract()
    {
        // Arrange
        var value1 = 5;
        var value2 = 3;
        var expected = 2;

        var systemUnderTest = new Calculator();

        // Act
        var actual = systemUnderTest.Subtract(value1, value2);

        // Assert
        Assert.Equal(expected, actual);


    }

    [Fact]
    public void Multiply()
    {
        // Arrange
        var value1 = 5;
        var value2 = 3;
        var expected = 15;

        var systemUnderTest = new Calculator();

        // Act
        var actual = systemUnderTest.Multiply(value1, value2);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide()
    {
        // Arrange
        var value1 = 10;
        var value2 = 2;
        var expected = 5;

        var systemUnderTest = new Calculator();

        // Act
        var actual = systemUnderTest.Divide(value1, value2);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        // Arrange
        var value1 = 10;
        var value2 = 0;

        var systemUnderTest = new Calculator();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => systemUnderTest.Divide(value1, value2));
    }

    [Fact]
    public void Calculate_OnUnknownOperation_ThrowsException()
    {
        // Arrange
        var systemUnderTest = new Calculator();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => systemUnderTest.Calculate("Unknown", 1, 2));
    }


    [Theory]
    [InlineData("Add", 1, 2, 3)]
    [InlineData("Subtract", 5, 3, 2)]
    [InlineData("Multiply", 5, 3, 15)]
    [InlineData("Divide", 10, 2, 5)]
    public void Calculate(string operation, int value1, int value2, int expected)
    {
        // Arrange 
        var systemUnderTest = new Calculator();

        // Act
        var actual = systemUnderTest.Calculate(operation, value1, value2);

        // Assert
        Assert.Equal(expected, actual);
    }
}
