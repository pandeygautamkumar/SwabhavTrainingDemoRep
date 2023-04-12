using RectangleEnumApp.Model;
using System;

namespace RectangleEnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
           CaseStudy2();
        }
        private static void CaseStudy1()
        {
            Rectangle rectangleA = new Rectangle(10, 20, ColorOption.GREEN);
            PrintDetails(rectangleA);
        }
        private static void CaseStudy2()
        {
            Rectangle rectangleB = new Rectangle(10, 20, ColorOption.GREEN,BorderOption.DOUBLE);
            PrintDetails(rectangleB);
        }
        static void PrintDetails(Rectangle rectangle)
        {
            Console.WriteLine("Width is " + rectangle.Width);
            Console.WriteLine("Height is " + rectangle.Height);
            Console.WriteLine("Color is " + rectangle.Color);
            Console.WriteLine("Border Style is " + rectangle.Border);
        }
    }
}
