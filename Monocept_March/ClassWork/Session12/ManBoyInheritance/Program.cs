using ManBoyInheritance.Model;
using System;

namespace ManBoyInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            //CaseStudy4();
            CaseStudy5();

        }

        private static void CaseStudy5()
        {
            Object box = 10;
            Console.WriteLine(box.GetType());
            box = "Hello";
            Console.WriteLine(box.GetType());
            box = new Man();
            Console.WriteLine(box.GetType());
            Man man = (Man)box;
            man.Play();
            man.Read();
        }

        private static void CaseStudy2()
        {
            Boy boy = new Boy();
            boy.Play();
            boy.Read();
            boy.Eat();
        }

        private static void CaseStudy1()
        {
            Man man = new Man();
            man.Play();
            man.Read();
        }

        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
        }

        private static void CaseStudy3()
        {
            Man x = new Boy();
            x.Play();
            x.Read();
            //boy1.Eat();
        }
        private static void AtThePark(Man man)
        {
            Console.Write("in the Park : ");
            man.Play();
        }
    }
}
