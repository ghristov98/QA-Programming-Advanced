using NUnit.Framework;

using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);
        // Assert
        Assert.AreEqual(result, numbers);
    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] array = new int[] { 12345 } ;
        int[] expected = new int[] { 12345 };
        // Act
        int[] result = Duplicates.RemoveDuplicates(array);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] array = new int[] { 1,5,3,4,5,3,6,5,3,1 };
        int[] expected = new int[] { 1,5,3,4,6 };
        // Act
        int[] result = Duplicates.RemoveDuplicates(array);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] array = new int[] { 5,5,5,5,5,5,5,5,5,5,5,5,5,5,5 };
        int[] expected = new int[] { 5 };
        // Act
        int[] result = Duplicates.RemoveDuplicates(array);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
