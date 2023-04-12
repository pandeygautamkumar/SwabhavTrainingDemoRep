using SingletonPatternAppV2.Service;

namespace SingletonPatternAppV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service1 = DataService.GetInstance();
            service1.DoProcessing();
            var service2 = DataService.GetInstance();
            service2.DoProcessing();
            var service3 = DataService.GetInstance();
            service3.DoProcessing();
            Console.WriteLine();

            Console.WriteLine("Service1 Hash Code " + service1.GetHashCode());
            Console.WriteLine("Service2 Hash Code " + service2.GetHashCode());
            Console.WriteLine("Service3 Hash Code " + service3.GetHashCode());
        }
    }
}