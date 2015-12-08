using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lib1.Test
{
    [TestClass]
    public class StringUtilsTests
    {
        [TestMethod]
        public void CharCountReturnsNumberOfChars()
        {
            // Arrange
            string value = "test";
            int expected = 4;
            int actual;

            // Act
            actual = StringUtils.CharCount(value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CharCountThrowsArgumentExceptionWithWhitespaceInput()
        {
            // Arrange
            string value = " ";

            // Act
            StringUtils.CharCount(value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CharCountThrowsArgumentNullExceptionWithNullInput()
        {
            // Arrange
            string value = null;

            // Act
            StringUtils.CharCount(value);
        }
    }
}
