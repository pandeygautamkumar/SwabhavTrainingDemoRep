using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleEnumApp.Model;

namespace RectangleUnitTestApp
{
    [TestClass]
    public class RectangleUnitTest
    {
        [TestMethod]
        public void Should_Checking_The_3_Parameter_Constructor()
        {
            BorderOption expectedBorder = BorderOption.SINGLE;
            Rectangle rectangle = new Rectangle(10, 20, ColorOption.BLUE) ;
            Assert.AreEqual(expectedBorder, rectangle.Border);
        }
        /*
        [TestMethod]
        public void Should_Check_The_4_Parameter_Constructor()
        {
            BorderOption expectedBorder = BorderOption.SINGLE;
            Rectangle rectangle = new Rectangle(10, 20, ColorOption.BLUE);
            Assert.AreEqual(expectedBorder, rectangle.Border);
        }*/

        [TestMethod]
        public void Should_Check_All_Attribute()
        {
            Rectangle rectangle = new Rectangle(10, 20, ColorOption.GREEN, BorderOption.DOTTED);
            int expectedWidth = 10;
            int expectedHeight = 20;
            ColorOption expectedColor = ColorOption.GREEN;
            BorderOption expectedBorder = BorderOption.DOTTED;
            Assert.AreEqual(expectedWidth, rectangle.Width);
            Assert.AreEqual(expectedHeight, rectangle.Height);
            Assert.AreEqual(expectedColor, rectangle.Color);
            Assert.AreEqual(expectedBorder, rectangle.Border);
        }

        [TestMethod]
        public void Should_Check_CalculateArea_if_Passed_Width_OR_Height_LessThen100_And_MoreThen1()
        {
            Rectangle rectangle = new Rectangle(10, 20, ColorOption.GREEN, BorderOption.DOTTED);
            int expectedArea = 200;
            int actualArea = rectangle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void Should_Check_CalculateArea_if_Passed_Width_OR_Height_GreaterThen100()
        {
            Rectangle rectangle = new Rectangle(8, 111, ColorOption.GREEN, BorderOption.DOTTED);
            int expectedArea = 800;
            int actualArea = rectangle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void Should_Check_CalculateArea_if_Passed_Width_OR_Height_LessThen1()
        {
            Rectangle rectangle = new Rectangle(8, -12, ColorOption.GREEN, BorderOption.DOTTED);
            int expectedArea = 8;
            int actualArea = rectangle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void Should_Check_Width_And_Height()
        {
            Rectangle rectangle = new Rectangle(-8,120, ColorOption.GREEN, BorderOption.DOTTED);
            int expectedWidth = 1;
            int expectedHeight = 100;
            Assert.AreEqual(expectedWidth,rectangle.Width);
            Assert.AreEqual(expectedHeight, rectangle.Height);
        }
        [TestMethod]
        public void Should_Check_BorderStyle_And_Color()
        {
            Rectangle rectangle = new Rectangle(8, 120, ColorOption.GREEN, BorderOption.DOTTED);
            rectangle.Border = BorderOption.DOUBLE;
            rectangle.Color = ColorOption.RED;
            BorderOption expectedBorder = BorderOption.DOUBLE;
            ColorOption expectedColor = ColorOption.RED;
            Assert.AreEqual(expectedBorder, rectangle.Border);
            Assert.AreEqual(expectedColor, rectangle.Color);
        }
    }
}
