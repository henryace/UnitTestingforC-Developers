using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class FizzBuzzTests
    {
        [Test]
        public void GetOutput_InputIsDividedBy3and5_ReturnsFizzBuzz()
        {
            // Arrange

            // Act
            var result = FizzBuzz.GetOutput(15);

            // Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        public void GetOutput_InputIsDividedBy3_or_5_ReturnsNotString(int input, string expectedResult)
        {
            // Arrange

            // Act
            var result = FizzBuzz.GetOutput(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(1, "1")]
        public void GetOutput_InputIsNotDividedBy3nor5_ReturnsString(int input, string expectedResult)
        {
            // Arrange

            // Act
            var result = FizzBuzz.GetOutput(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}