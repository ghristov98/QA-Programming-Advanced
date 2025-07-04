using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        // Arrange
        string sentence = "";
        List<char> forbiddenChars = new List<char>() { 'a', 'e' };
        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);
        // Assert
        Assert.That(result, Is.EqualTo(sentence));
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        // Arrange
        string sentence = "I am Georgi.I am 26 years old.";
        List<char> forbiddenChars = new List<char>();
        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);
        // Assert
        Assert.That(result, Is.EqualTo(sentence));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        // Arrange
        string sentence = "d";
        List<char> forbiddenChars = new List<char>() { 'd' };
        string expectedResult = "";
        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);
        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        // Arrange
        string sentence = "I am Georgi and I am 26 years old.";
        List<char> forbiddenChars = new List<char>() { 'e', 'i', 'I' };
        string expectedResult = " am Gorg and  am 26 yars old.";
        // Act
        string result = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);
        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
