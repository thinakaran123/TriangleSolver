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
    [TestFixture]
    public class ScaleneTriangleTests
    {
        [Test]
        public void GivenAllSidesDifferent_WhenAnalyzing_ThenReturnsScalene()
        {
            // Arrange
            int sideOne = 6;
            int sideTwo = 7;
            int sideThree = 8;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenAnotherVariation_WhenAnalyzing_ThenReturnsScalene()
        {
            // Arrange
            int sideOne = 3;
            int sideTwo = 4;
            int sideThree = 5;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenLargeSides_WhenAnalyzing_ThenReturnsScalene()
        {
            // Arrange
            int sideOne = 12;
            int sideTwo = 15;
            int sideThree = 17;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenSmallestValidTriangle_WhenAnalyzing_ThenReturnsScalene()
        {
            // Arrange
            int sideOne = 2;
            int sideTwo = 3;
            int sideThree = 4;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenLargeTriangle_WhenAnalyzing_ThenReturnsScalene()
        {
            // Arrange
            int sideOne = 20;
            int sideTwo = 25;
            int sideThree = 30;
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
    [TestFixture]
    public class ZeroLengthSideTests
    {
        [Test]
        public void GivenZeroLengthSideOne_WhenAnalyzing_ThenReturnsInvalidMessage()
        {
            // Arrange
            int sideOne = 0;
            int sideTwo = 5;
            int sideThree = 7;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenZeroLengthSideTwo_WhenAnalyzing_ThenReturnsInvalidMessage()
        {
            // Arrange
            int sideOne = 5;
            int sideTwo = 0;
            int sideThree = 7;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenZeroLengthSideThree_WhenAnalyzing_ThenReturnsInvalidMessage()
        {
            // Arrange
            int sideOne = 5;
            int sideTwo = 7;
            int sideThree = 0;
            string expected = "Invalid Triangle - a zero has been detected";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
    [TestFixture]
    public class InvalidTriangleTests
    {
        [Test]
        public void GivenSumOfTwoSidesLessThanThird_WhenAnalyzing_ThenReturnsInvalid()
        {
            // Arrange
            int sideOne = 2;
            int sideTwo = 2;
            int sideThree = 5;
            string expected = "INVALID!!";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenSumOfTwoSidesEqualsThird_WhenAnalyzing_ThenReturnsInvalid()
        {
            // Arrange
            int sideOne = 5;
            int sideTwo = 5;
            int sideThree = 10;
            string expected = "INVALID!!";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenAllSidesTooSmall_WhenAnalyzing_ThenReturnsInvalid()
        {
            // Arrange
            int sideOne = 1;
            int sideTwo = 1;
            int sideThree = 3;
            string expected = "INVALID!!";

            // Act
            string result = Triangle.AnalyzeTriangle(sideOne, sideTwo, sideThree);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
