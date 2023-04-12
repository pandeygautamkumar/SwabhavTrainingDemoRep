using System;

namespace TryParseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str ="A";
            int x;
            Boolean result = int.TryParse(str, out x);
            Console.WriteLine(result);
            Console.WriteLine(x);
        }
    }
}
