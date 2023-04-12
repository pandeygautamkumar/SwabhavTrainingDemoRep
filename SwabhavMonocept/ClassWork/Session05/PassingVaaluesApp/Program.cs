using System;

namespace PassingVaaluesApp
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
            DisplayMultiplication(first: 10);
            DisplayMultiplication(first: 10,20);
            DisplayMultiplication(first: 10,20,30,40,50);
        }
        private static void DisplayMultiplication(int first,params int[] numbers)
        {
            int product = first;
            foreach(int number in numbers)
            {
                product += number;
            }
            Console.WriteLine(format: "Product is {0} ", product);
        }
        private static void CaseStudy4()
        {
            int sum, avg, product;
            Calculate(10, 20, 30, out sum, out avg, out product);
            Console.WriteLine("Sum is {0} avg is {1} product {2} ", sum, avg, product);
            Console.WriteLine("Enter Only Number ");
            string input = Console.ReadLine();
            int no = 0;
            if (int.TryParse(input, out no))
            {
                Console.WriteLine(no * no);
            }
            else
            {
                Console.WriteLine("Only Number Will be Alowed");
            }
        }
        private static void Calculate(int first, int second, int third, out int sum, out int avg, out int product)
        {
            sum = first + second + third;
            avg = sum / 3;
            product = first * second * third;
        }
        private static void CaseStudy3()
        {
            int[] scores = { 10, 20, 30, 40, 50 };
            UpdateScoresToZero(scores);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine("HashCode of scores is {0} : ", scores.GetHashCode());
        }
        private static void UpdateScoresToZero(int[] pScores)
        {
            for (int i = 0; i < pScores.Length; i++)
            {
                pScores[i] = 0;
            }
            Console.WriteLine("HashCode of pScores is {0} : ", pScores.GetHashCode());
        }
        private static void CaseStudy2()
        {
            int salary = 1000;
            UpdateSalaryToZero(ref salary);
            Console.WriteLine("CaseStudy2, salary value is : {0} ", salary);
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
