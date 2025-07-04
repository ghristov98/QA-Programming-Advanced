using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";
        // Act
        bool result = Email.IsValidEmail(validEmail);
        // Assert
        Assert.IsTrue(result);
    }

    [TestCase("@example.com")]
    [TestCase("testexample.com")]
    [TestCase("testexamplecom")]
    public void Test_IsValidEmail_InvalidEmail(string invalidEmail)
    {
        // Act
        bool result = Email.IsValidEmail(invalidEmail);
        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string validEmail = null;
        // Act
        bool result = Email.IsValidEmail(validEmail);
        // Assert
        Assert.That(result, Is.False);
    }
}
