using RectangleConstructorApp.Model;
using System;

namespace RectangleConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(new Rectangle(width: 10, height: 20, color: "blue"),"Anonymous Object");
            Rectangle rectangleA = new Rectangle(100, 50, "Green");
            PrintDetails(rectangleA, "Rectangle A");
            rectangleA.SetColor("Red");
            PrintDetails(rectangleA, "Rectangle A after Color Change");
        }
        static void PrintDetails(Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Width is {rectangle.GetWidth()}");
            Console.WriteLine($"Height is {rectangle.GetHeight()}");
            Console.WriteLine($"Color is {rectangle.GetColor()}");
            Console.WriteLine($"Area is {rectangle.CalculateArea()}");

            Console.WriteLine();
        }
    }
}
