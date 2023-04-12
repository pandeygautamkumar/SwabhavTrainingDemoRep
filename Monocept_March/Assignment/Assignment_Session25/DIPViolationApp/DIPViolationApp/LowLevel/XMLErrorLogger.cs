
using DIPViolationApp.HighLevel;

namespace DIPViolationApp.LowLevel
{
    internal class XMLErrorLogger : IErrorLogger
    {
        public void Log(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Writing into XML file...please Wait...");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();
        }
    }
}
