using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] emptyArray = Array.Empty<double>();
        // Act
        double[] result = Sorting.ShallowAscendingSort(emptyArray);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] emptyArray = Array.Empty<double>();
        // Act
        double[] result = Sorting.DeepAscendingSort(emptyArray);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        // Arrange
        double[] originalArray = { 4.2, 1.5, 6.7, 5.5, 4.0 };
        double[] originalExpected = { 4.2, 1.5, 6.7, 5.5, 4.0 };
        double[] expected = { 1.5, 4.0, 4.2, 5.5, 6.7 };
        // Act
        double[] result = Sorting.ShallowAscendingSort(originalArray);
        // Assert
        CollectionAssert.AreEqual(expected, result);
        CollectionAssert.AreEqual(originalExpected, originalArray);
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        // Arrange
        double[] originalArray = { 4.2, 1.5, 6.7, 5.5, 4.0 };
        double[] expected = { 1.5, 4.0, 4.2, 5.5, 6.7 };
        // Act
        double[] result = Sorting.DeepAscendingSort(originalArray);
        // Assert
        CollectionAssert.AreEqual(expected, result);
        CollectionAssert.AreEqual(expected, originalArray);
    }
}
