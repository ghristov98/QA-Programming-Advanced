using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        List<int> palindromes = new List<int>();
        // Act
        PalindromeIntegers pi = new PalindromeIntegers();
        List<int> result = pi.FindPalindromes(palindromes);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        List<int> palindromes = new List<int>() { 123, 345, 678 };
        // Act
        PalindromeIntegers pi = new PalindromeIntegers();
        List<int> result = pi.FindPalindromes(palindromes);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> palindromes = new List<int>() { 3, 5, 8, 9};
        // Act
        PalindromeIntegers pi = new PalindromeIntegers();
        List<int> result = pi.FindPalindromes(palindromes);
        // Assert
        Assert.That(result, Is.EqualTo(palindromes));
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> palindromes = new List<int>() { 3223, 52325, 8008, 9123219 };
        // Act
        PalindromeIntegers pi = new PalindromeIntegers();
        List<int> result = pi.FindPalindromes(palindromes);
        // Assert
        Assert.That(result, Is.EqualTo(palindromes));
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> palindromes = new List<int>() { 3223, 52325, 42, 563 };
        List<int> expected = new List<int>() { 3223, 52325};
        // Act
        PalindromeIntegers pi = new PalindromeIntegers();
        List<int> result = pi.FindPalindromes(palindromes);
        // Assert
        CollectionAssert.AreEqual(result, expected);
    }
}
