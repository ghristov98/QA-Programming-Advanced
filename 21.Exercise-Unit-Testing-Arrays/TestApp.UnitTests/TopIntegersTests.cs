using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        // Arrange
        int[] array = Array.Empty<int>();
        string expected = string.Empty;
        // Act
        TopIntegers topIntegers = new TopIntegers();
        string result = topIntegers.FindTopIntegers(array);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        // Arrange
        int[] array = new int[] { 6, 5, 4 };
        string expected = "6 5 4";
        // Act
        TopIntegers topIntegers = new TopIntegers();
        string result = topIntegers.FindTopIntegers(array);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] array = new int[] { 6 };
        string expected = "6";
        // Act
        TopIntegers topIntegers = new TopIntegers();
        string result = topIntegers.FindTopIntegers(array);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        // Arrange
        int[] array = new int[] { 6, 5, 4, 10, 9};
        string expected = "10 9";
        // Act
        TopIntegers topIntegers = new TopIntegers();
        string result = topIntegers.FindTopIntegers(array);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

