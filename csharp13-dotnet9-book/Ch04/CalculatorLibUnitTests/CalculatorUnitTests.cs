using CalculatorLib;

namespace CalculatorLibUnitTests;

public class CalculatorUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {
        // Arrange
        double a = 2;
        double b = 2;
        double expected = 4;
        
        // Act
        double actual = new Calculator().Add(a, b);
        
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestAdding2And3()
    {
        // Act
        double a = 2;
        double b = 3;
        double expected = 5;
        
        // Assert
        double actual = new Calculator().Add(a, b);
        
        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(2, 3, 5)]
    [InlineData(9, 9, 18)]
    public void TestAdding(double a, double b, double expected)
    {
        // Arrange
        Calculator calculator = new();
        
        // Act
        double actual = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }
}
