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
}
