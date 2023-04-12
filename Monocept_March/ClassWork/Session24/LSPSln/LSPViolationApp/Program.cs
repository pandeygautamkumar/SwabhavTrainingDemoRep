using LSPViolationApp.Model;

namespace LSPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoudNotChangeHeight_IfWidthIsModified(new Rectangle(100, 20));

            ShoudNotChangeHeight_IfWidthIsModified(new Square(100));
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
    }
}