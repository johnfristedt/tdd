using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lib1.Test
{
    [TestClass]
    public class MathUtilsTests
    {
        [TestMethod]
        public void OnePlusOneReturnsTwo()
        {
            // Arrange
            int expected = 2;
            int actual;

            // Act
            actual = MathUtils.OnePlusOne();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XPlusYReturnsSum()
        {
            // Arrange
            int valueX = 5;
            int valueY = 7;
            int expected = 12;
            int actual;

            // Act
            actual = MathUtils.XPlusY(valueX, valueY);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void XDivideYReturnsQuotient()
        {
            // Arrange
            float x = 10f;
            float y = 2f;
            float expected = 5f;
            float actual;

            // Act
            actual = MathUtils.XDivideY(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void XDivideYThrowsArgumentExceptionOnYZero()
        {
            // Arrange
            int x = 10;
            int y = 0;

            // Act
            MathUtils.XDivideY(x, y);
        }
    }
}
