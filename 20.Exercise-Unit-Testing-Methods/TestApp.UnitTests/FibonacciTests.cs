using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int fibonacci = 0;
        int expected = 0;
        // Act
        int result = Fibonacci.CalculateFibonacci(fibonacci);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int fibonacci = 10;
        int expected = 55;
        // Act
        int result = Fibonacci.CalculateFibonacci(fibonacci);
        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }
}