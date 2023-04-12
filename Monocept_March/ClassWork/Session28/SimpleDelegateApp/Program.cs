namespace SimpleDelegateApp
{
    delegate void DPrintMessage(string name);
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
            DPrintMessage x = (n) => Console.WriteLine("Lembda {0}", n);
            x("Gautam");
        }

        private static void CaseStudy2()
        {
            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);
            
            PrintWizard(delegate (string name)
            {
                Console.WriteLine("Anonymous Delegate function 1");
                Console.WriteLine(name.ToLower());
            });

            PrintWizard((name) =>
            {
                Console.WriteLine("Inside Lambda function");
                Console.WriteLine(name.ToLower());
            });
            
        }

        static void PrintWizard(DPrintMessage fptr)
        {
            Console.WriteLine("Doing Printing Operations...");
            Console.WriteLine("Operation Completed.");
            fptr("CHAMP");
            Console.WriteLine();
        }

        private static void CaseStudy1()
        {
            DPrintMessage obj = PrintHello;
            //obj("Gautam");
            obj += PrintGoodBye;
            obj += PrintHello;
            obj += PrintHello;
            //obj += Foo;
            obj.Invoke("Ekta");
            obj("Gautam");
        }

        private static void PrintHello(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
        private static void PrintGoodBye(string name)
        {
            Console.WriteLine("Goodbye {0}", name);
        }
        private static void Foo()
        {
            Console.WriteLine("Inside Foo");
        }
    }
}