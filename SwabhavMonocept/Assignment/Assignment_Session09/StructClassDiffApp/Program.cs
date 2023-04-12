using System;
using StructClassDiffApp.Model;
namespace StructClassDiffApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            PointStructure ps = new PointStructure(50, 50);
            Console.WriteLine("Before Modification : ");
            ps.ShowPoint();
            ModifyStructValues(ps);
            Console.WriteLine("After Modification : ");
            ps.ShowPoint();
        }

        private static void CaseStudy1()
        {
            PointClass pointClass = new PointClass(10, 20);
            Console.WriteLine("Before Modification : ");
            pointClass.ShowPoint();
            ModifyClassValues(pointClass);
            Console.WriteLine("After Modification : ");
            pointClass.ShowPoint();
        }

        private static void ModifyStructValues(PointStructure ps)
        {
            ps.GetX += 100;
            ps.GetY += 100;
        }
        private static void ModifyClassValues(PointClass pointClass)
        {
            pointClass.GetX += 100;
            pointClass.GetY += 100;
        }
    }
}
