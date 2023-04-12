using System;

namespace PassingValuesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStudy3()
        {
            int[] scores = { 10, 20, 30, 40, 50 };
            UpdateScoresToZero(scores);
            foreach(int score in scores)
            {
                Console.Write(score+" ");
            }
            Console.WriteLine();
            Console.WriteLine("HashCode of scores is {0} : ", scores.GetHashCode());
        }
        private static void UpdateScoresToZero(int[] pScores)
        {
            for(int i = 0; i < pScores.Length; i++)
            {
                pScores[i] = 0;
            }
            Console.WriteLine("HashCode of pScores is {0} : ", pScores.GetHashCode());
        }
        private static void CaseStudy2()
        {
            int salary = 1000;
            UpdateSalaryToZero(ref salary);
            Console.WriteLine("CaseStudy2, salary value is : {0} ",salary);
        }
        private static void UpdateSalaryToZero(ref int pSalary)
        {
            pSalary = 0;
        }
        private static void CaseStudy1()
        {
            int mark = 100;
            UpdateMarkToZero(mark);
            Console.WriteLine("CaseStudy1, mark value is {0} ", mark);
        }
        private static void UpdateMarkToZero(int marks)
        {
            marks = 0;
        }
    }
}
