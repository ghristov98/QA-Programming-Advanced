using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> elements = new List<int>() { 5 };
        int expected = 5;
        // Act
        List<int> result = GaussTrick.SumPairs(elements);

        // Assert
        CollectionAssert.AreEquivalent(elements, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new List<int>() { 5, 4, 1, 2 };
        List<int> expected = new List<int>() { 7, 5 };
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // TODO: finish the test
        // Arrange
        List<int> list = new List<int>() { 5, 4, 1, 2, 8, 3 };
        List<int> expected = new List<int>() { 8, 12, 3 };
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new List<int>() { 10, 20, 30, 40, 50, 80, 90 };
        List<int> expected = new List<int>() { 100, 100, 80, 40 };
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new List<int>() { 13, 33,55,47,27};
        List<int> expected = new List<int>() { 40, 80,55 };
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
