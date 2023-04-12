using SingletonPatternMultithreddingApp.Service;

namespace SingletonPatternMultithreddingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            DoSomething();
            DoSomething();
            DoSomething();
            DoSomething();
            DoSomething();
        }

        private static void CaseStudy2()
        {
            Thread t1 = new Thread(DoSomething);
            Thread t2 = new Thread(DoSomething);
            Thread t3 = new Thread(DoSomething);
            Thread t4 = new Thread(DoSomething);
            Thread t5 = new Thread(DoSomething);

            t3.Start();
            t4.Start();
            t1.Start();
            t2.Start();
            t5.Start();
        }

        private static void DoSomething()
        {
            DataService.GetInstance().DOProcessing();
        }
    }
}