using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = new char[] { '0', '1', 'A', '#', '9' };
        char[] expected = new char[] { 'A', '#' };
        // Act
        char[] result = Fake.RemoveStringNumbers(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = new char[] { 'B', 'e', 'A', '#', 'C' };
        char[] expected = new char[] { 'B','e', 'A', '#','C' };
        // Act
        char[] result = Fake.RemoveStringNumbers(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = new char[] { };
        char[] expected = new char[] { };
        // Act
        char[] result = Fake.RemoveStringNumbers(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
