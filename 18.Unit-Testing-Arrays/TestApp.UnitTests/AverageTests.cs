using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = new int[] { 42 };
        int expected = 42;
        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = new int[] { 50, 5, 5 };
        double expected = 20;
        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = new int[] { -10, -5, -6 };
        double expected = -7;
        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = new int[] { 50, 5, 5, -20 };
        double expected = 10;
        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // Demo test of all uper tests by using TestCase scenario

    [Test] 
    [TestCase(new int[] { 42 }, 42)]
    [TestCase(new int[] { 50, 5, 5 }, 20)]
    [TestCase(new int[] { -10, -5, -6 }, -7)]
    [TestCase(new int[] { 50, 5, 5, -20 }, 10)]
    public void Test_CalculateAverage_MixedTestCases(int[] array, double expected)
    {
        // Arrange
      
        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
