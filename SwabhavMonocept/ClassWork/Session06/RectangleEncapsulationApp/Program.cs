using RectangleEncapsulationApp.Model;
using System;

namespace RectangleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA = new Rectangle();
            rectangleA.SetWidth(101);
            rectangleA.SetHeight(-100);
            rectangleA.SetColor("Abcd");
            /*
            Console.WriteLine($"Width is {rectangleA.GetWidth()}");
            Console.WriteLine($"Height is {rectangleA.GetHeight()}");
            Console.WriteLine($"Color is {rectangleA.GetColor()}");
            Console.WriteLine($"Area is {rectangleA.CalculateArea()}");
            */
            PrintDetails(rectangleA, "Details of Rectangle A");

            Rectangle rectangleB = new Rectangle();
            rectangleB.SetWidth(20);
            rectangleB.SetHeight(30);
            rectangleB.SetColor("blue");
            /*
            Console.WriteLine($"Width is {rectangleB.GetWidth()}");
            Console.WriteLine($"Height is {rectangleB.GetHeight()}");
            Console.WriteLine($"Color is {rectangleB.GetColor()}");
            Console.WriteLine($"Area is {rectangleB.CalculateArea()}");
            */
            PrintDetails(rectangleB, "Details of Rectangle B");
        }

        static void PrintDetails(Rectangle rectangle,string description)
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
