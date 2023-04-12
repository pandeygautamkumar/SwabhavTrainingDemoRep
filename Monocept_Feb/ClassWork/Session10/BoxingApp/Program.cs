using System;

namespace BoxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy2()
        {
            Object[] boxedItems = new object[3];
            boxedItems[0] = 10d;
            boxedItems[1] = 20.55d;
            boxedItems[2] = 30.45d;
            Console.WriteLine(boxedItems[0].GetType());
            Console.WriteLine(boxedItems[1].GetType());
            Console.WriteLine(boxedItems[2].GetType());
            double sum = 0;
            foreach(Object obj in boxedItems){
                sum +=(double)obj;
            }
            Console.WriteLine("Sum will be : " + sum);
        }

        private static void CaseStudy1()
        {
            Object box = null;   // box expects object of object class
            //int no = 100;
            box = new object();
            Console.WriteLine(box.GetType());
            box = 100.55;
            Console.WriteLine(box.GetType());
            Console.WriteLine(box.GetHashCode());
            box =(double)box+1.45;
            Console.WriteLine(box);
        }
    }
}
