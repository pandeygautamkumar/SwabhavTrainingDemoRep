
using DIPViolationApp.HighLevel;

namespace DIPViolationApp.LowLevel
{
    internal class TextErrorLogger : IErrorLogger
    {
        public void Log(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Writing into Text file...please Wait...");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();
        }
    }
}
