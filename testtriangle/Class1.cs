using System;
using NUnit.Framework;
using TriangleSolver;

namespace TestTriangle
{
    [TestFixture]
    public class EquilateralTriangleTests
    {
        [Test]
        public void GivenEquilateralSides_WhenAnalyzing_ThenReturnsEquilateral()
        {
            // Arrange
            int sideOne = 10;
            int sideTwo = 10;
            int sideThree = 10;
            string expected = "Equilateral triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
    [TestFixture]
    public class IsoscelesTriangleTests
    {
        [Test]
        public void GivenTwoEqualSides_WhenAnalyzing_ThenReturnsIsosceles()
        {
            // Arrange
            int sideOne = 10;
            int sideTwo = 10;
            int sideThree = 15;
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenDifferentSideInMiddle_WhenAnalyzing_ThenReturnsIsosceles()
        {
            // Arrange
            int sideOne = 7;
            int sideTwo = 9;
            int sideThree = 7;
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenDifferentSideAtEnd_WhenAnalyzing_ThenReturnsIsosceles()
        {
            // Arrange
            int sideOne = 5;
            int sideTwo = 8;
            int sideThree = 8;
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
