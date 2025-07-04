using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.50, "Fail")]
    [TestCase(3.00, "Average")]
    [TestCase(4.30, "Good")]
    [TestCase(5.25, "Very Good")]
    [TestCase(6.00, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange
       
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [TestCase(1.99, "Invalid!")]
    [TestCase(6.99, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange
        
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
