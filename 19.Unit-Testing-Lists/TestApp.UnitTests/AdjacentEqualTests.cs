using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new List<int>();
        string expected = "";

        // Act
        string resultText = AdjacentEqual.Sum(emptyList);
        // Assert
        Assert.That(resultText, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> noEqualNumbers = new List<int>() { 1, 2, 3, 4, 5 };
        string expected = "1 2 3 4 5";
        // Act
        string resultText = AdjacentEqual.Sum(noEqualNumbers);
        // Assert
        Assert.That(resultText, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> noEqualNumbers = new List<int>() { 1, 2, 4, 4, 4 };
        string expected = "1 2 12";
        // Act
        string resultText = AdjacentEqual.Sum(noEqualNumbers);
        // Assert
        Assert.That(resultText, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> noEqualNumbers = new List<int>() { 5, 5, 5, 5, 5 };
        string expected = "25";
        // Act
        string resultText = AdjacentEqual.Sum(noEqualNumbers);
        // Assert
        Assert.That(resultText, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> noEqualNumbers = new List<int>() { 1, 1, 1, 4, 5, 6, 7 };
        string expected = "3 4 5 6 7";
        // Act
        string resultText = AdjacentEqual.Sum(noEqualNumbers);
        // Assert
        Assert.That(resultText, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> noEqualNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 7, 7, 7 };
        string expected = "1 2 3 4 5 6 28";
        // Act
        string resultText = AdjacentEqual.Sum(noEqualNumbers);
        // Assert
        Assert.That(resultText, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> noEqualNumbers = new List<int>() { 1, 2, 3, 4, 5, 5, 7, 8, 9, 10 };
        string expected = "1 2 3 4 10 7 8 9 10";
        // Act
        string resultText = AdjacentEqual.Sum(noEqualNumbers);
        // Assert
        Assert.That(resultText, Is.EqualTo(expected));
    }
}
