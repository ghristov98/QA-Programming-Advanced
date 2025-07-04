using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        // Arrange  
        List<int> emptyList = new List<int>();
        string expectedText = "No elements!";
        // Act  
        string resultText = ListAnalyzer.Analyze(emptyList);
        // Assert  
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange  
        List<int> oneElement = new List<int>() { 6 };
        string expectedElement = "Element count: 1, Min value: 6, Max value: 6, Avg: 6.00.";
        // Act  
        string resultText = ListAnalyzer.Analyze(oneElement);
        // Assert  
        Assert.That(resultText, Is.EqualTo(expectedElement));
    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        // Arrange
        List<int> sameElements = new List<int>() { 6, 6, 6, 6, 6 };
        string expectedElements = "Element count: 5, Min value: 6, Max value: 6, Avg: 6.00.";
        // Act
        string resultText = ListAnalyzer.Analyze(sameElements);
        // Assert
        Assert.That(resultText, Is.EqualTo(expectedElements));
    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        // Arrange
        List<int> differentValues = new List<int>() { 1, 2, 3, 4, 5, 6 };
        string expectedValue = "Element count: 6, Min value: 1, Max value: 6, Avg: 3.50.";
        // Act
        string resultText = ListAnalyzer.Analyze(differentValues);
        // Assert
        Assert.That(resultText , Is.EqualTo(expectedValue));
    }
}
