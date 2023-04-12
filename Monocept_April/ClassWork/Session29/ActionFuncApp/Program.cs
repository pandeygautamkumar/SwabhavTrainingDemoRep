namespace ActionFuncApp
{
    internal class Program
    {
        delegate bool DChecker(int no);
        delegate bool DNameChecker(string name);
        delegate void DAdd(int firstNo, int secondNo);
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            /*
                        DAdd obj = Add;
                        obj(30, 40);
                        */

            Action<int, int> addPtr = Add;
            addPtr(30, 40);
        }

        private static void CaseStudy2()
        {
            /*
            DNameChecker check = CheckIsLongName;
            Console.WriteLine(check("Gautam Kumar Pandey"));
            */
            Func<string, bool> longNameCheckPtr = CheckIsLongName;
            Console.WriteLine(longNameCheckPtr("Gautam Kumar Pandey"));
        }

        private static void CaseStudy1()
        {
            DChecker isEvenPtr = CheckEven;
            // Predicate<int> isEvenPtr = CheckEven;
            Console.WriteLine(isEvenPtr(30));
        }

        private static bool CheckEven(int no)
        {
            return no % 2 == 0;
        }
        private static bool CheckIsLongName(string name)
        {
            return (name.Length >= 8);
        }
        private static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} ={2}", a, b, a + b);
        }
    }
}