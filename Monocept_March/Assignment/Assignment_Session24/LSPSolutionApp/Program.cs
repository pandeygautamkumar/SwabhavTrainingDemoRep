using LSPSolutionApp.Model;

namespace LSPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
        }

        private static void CaseStudy2()
        {
            IPolygon polygon = new Rectangle(100, 10);
            PrintPolygonDetails(polygon);

            polygon = new Square(10);
            PrintPolygonDetails(polygon);
        }

        private static void CaseStudy1()
        {
            ShoudNotChangeHeight_IfWidthIsModified(new Rectangle(100, 20));

            //ShoudNotChangeHeight_IfWidthIsModified(new Square(100));
        }

        private static void ShoudNotChangeHeight_IfWidthIsModified(Rectangle rectangle)
        {
            int beforeChange = rectangle.GetHeight();
            rectangle.SetWidth(rectangle.GetWidth() + 10);
            int afterChange = rectangle.GetHeight();
            Console.WriteLine(beforeChange == afterChange);
            Console.WriteLine(beforeChange);
            Console.WriteLine(afterChange);
        }
        public static void PrintPolygonDetails(IPolygon polygon)
        {
            Console.WriteLine("Area of Polygon is : "+polygon.CalculateArea());
            Console.WriteLine("Perimeter of Polygon is : " + polygon.CalculatePerimeter());
        }
    }
}