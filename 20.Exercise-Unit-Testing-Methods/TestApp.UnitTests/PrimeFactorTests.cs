using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long primeNum = 11;
        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(primeNum);
        // Assert
        Assert.That(result, Is.EqualTo(primeNum));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long num = 48625;
        long expected = 389;
        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(num);
        // Assert    
        Assert.That(result, Is.EqualTo(expected));
    }
}

