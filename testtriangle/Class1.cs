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
}
