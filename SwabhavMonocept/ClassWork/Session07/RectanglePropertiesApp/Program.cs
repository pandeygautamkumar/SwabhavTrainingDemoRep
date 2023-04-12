using RectanglePropertiesApp.Model;
using System;

namespace RectanglePropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA = new Rectangle(100, 50, "Green");
            PrintDetails(rectangleA, "Rectangle A");
            rectangleA.Color = "Red";

            PrintDetails(rectangleA, "Rectangle A after Color Change");
        }

        static void PrintDetails(Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Width is : "+rectangle.Width);
            Console.WriteLine("Height is : "+rectangle.Height);
            Console.WriteLine("Color is : "+rectangle.Color);
            Console.WriteLine("Area is : "+rectangle.CalculateArea());

            Console.WriteLine();
        }
    }
}
