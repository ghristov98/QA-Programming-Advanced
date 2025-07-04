using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string empty = string.Empty;
        string expected = "Empty string";
        // Act
        string result = MiddleCharacters.GetMiddleChars(empty);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string empty = "  ";
        string expected = "Empty string";
        // Act
        string result = MiddleCharacters.GetMiddleChars(empty);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        // Arrange
        string single = "c";
        string expected = "c";
        // Act
        string result = MiddleCharacters.GetMiddleChars(single);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        // Arrange
        string twoChars = "dogo";
        string expected = "og";
        // Act
        string result = MiddleCharacters.GetMiddleChars(twoChars);
        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        // Arrange
        string oddChars = "Hello";
        string expected = "l";
        // Act
        string result = MiddleCharacters.GetMiddleChars(oddChars);
        // Assert
        Assert.AreEqual(expected, result);
    }
}
