using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleUnitTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleUnitTestApp
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void ShouldCalculate_AreaOfRectangle_With_Width_5_And_Height_10()
        {
            Rectangle rect = new Rectangle();
            rect.width = 5;
            rect.height = 10;
            int expectedArea = 50;
            int actualArea = rect.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void ShouldCalculate_AreaOfRectangle_WithWidth_15_And_Height_20()
        {
            Rectangle rect = new Rectangle();
            rect.width = 15;
            rect.height = 20;
            int expectedArea = 300;
            int actualArea = rect.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void ShouldCreate_Rectangle_With_Given_Width_And_Height()
        {
            int expectedWidth = 5;
            int expectedHeight = 10;
            Rectangle rectangle = new Rectangle(5, 10);

            Assert.AreEqual(expectedWidth, rectangle.width);
            Assert.AreEqual(expectedHeight, rectangle.height);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ShouldThrow_Exception_On_Creating_Rectangle_With_Negative_Width()
        {
            Rectangle rectangle = new Rectangle(-5, 10);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ShouldThrow_Exception_On_Creating_Rectangle_With_Negative_Height()
        {
            Rectangle rectangle = new Rectangle(5, -10);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ShouldThrow_Exception_On_Creating_Rectangle_With_0_Width()
        {
            Rectangle rectangle = new Rectangle(0, 10);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ShouldThrow_Exception_On_Creating_Rectangle_With_0_Height()
        {
            Rectangle rectangle = new Rectangle(5, 0);
        }

    }
}
