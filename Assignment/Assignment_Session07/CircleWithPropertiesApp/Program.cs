using CircleWithPropertiesApp.Model;
using System;

namespace CircleWithPropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circleA = new Circle(12.34f,"Green","Dotted");
            PrintDetails(circleA, "Details of Circle A");
            circleA.Radius=23.23f;
            circleA.Color="Yellow";
            circleA.BorderStyle="Double Line";
            PrintDetails(circleA, "Details of Circle A After Change");
        }
        static void PrintDetails(Circle circle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Redius of Circle : "+circle.Radius);
            Console.WriteLine("Color of Circle : "+circle.Color);
            Console.WriteLine("BorderStyle of Circle : "+circle.BorderStyle);
            Console.WriteLine("Area of Circle : "+circle.CalculateArea());
            Console.WriteLine("Circumference of Circle : "+circle.CalculateCircumference());

            Console.WriteLine();
        }
    }
}
