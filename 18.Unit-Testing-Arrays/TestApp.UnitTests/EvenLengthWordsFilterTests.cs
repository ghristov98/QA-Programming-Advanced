using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {

        // Arrange
        string[] array = new string[] {"","","" };
        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        // Arrange
        string[] array = new string[] { "abc" };
        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        // Arrange
        string[] array = new string[] { "abc", "abcdf", "x"};
        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        // Arrange
        string[] array = new string[] { "abcd" };
        string expected = "abcd";
        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        // Arrange
        string[] array = new string[] { "abcd", "abcdf", "ab" };
        string expected = "abcd ab";
        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

