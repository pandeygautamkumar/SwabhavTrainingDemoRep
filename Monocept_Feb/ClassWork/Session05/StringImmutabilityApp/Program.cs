using System;
using System.Text;

namespace StringImmutabilityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStudy1()
        {
            String userName = "Gautam";
            userName.ToUpper();
            Console.WriteLine(userName);
        }
        private static void CaseStudy3()
        {
            StringBuilder userName = new StringBuilder();
            Console.WriteLine(userName.GetHashCode());
            userName.Append("Gautam");
            userName.Append(" Developer");
            Console.WriteLine(userName.GetHashCode());
            userName.Append(" @Monocept");
            userName.Append(" Hyderabad.");
            Console.WriteLine(userName);
            Console.WriteLine(userName.GetHashCode());

        }
        private static void CaseStudy2()
        {
            String userName = "Gautam";
            Console.WriteLine(userName.GetHashCode());
            userName += " Developer";
            Console.WriteLine(userName.GetHashCode());
            userName += " @Monocept";
            Console.WriteLine(userName.GetHashCode());
            userName += " Hyderabad";
            Console.WriteLine(userName.GetHashCode());

            Console.WriteLine(userName);
        }
    }
}
