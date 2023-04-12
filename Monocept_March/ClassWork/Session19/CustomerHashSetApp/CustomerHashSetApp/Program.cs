using CustomerHashSetApp.Model;

namespace CustomerHashSetApp
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
            Customer c1 = new Customer(1, "Anikant");
            Customer c2 = new Customer(1, "Anikant");
            Customer c3 = new Customer(2, "Gautam");

            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
            Console.WriteLine(c3.GetHashCode());

            HashSet<Customer> customers = new HashSet<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            Console.WriteLine("Number of Customer is : " +customers.Count);

            foreach (Customer customer in customers)
            {
                Console.WriteLine("id : " + customer.Id + "  Name : " + customer.Name);
            }
        }

        private static void CaseStudy2()
        {
            HashSet<int> scores = new HashSet<int>();
            scores.Add(1001);
            scores.Add(10);
            scores.Add(5);

            scores.Add(1001);
            scores.Add(10);
            scores.Add(5);

            scores.Add(30);
            scores.Add(100000001);
            Console.WriteLine(scores.Count);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }

        private static void CaseStudy1()
        {
            HashSet<String> userNames = new HashSet<string>();
            userNames.Add("Anekant");
            userNames.Add("Ravi");
            userNames.Add("Subh");
            userNames.Add("Subh");
            userNames.Add("ravi");
            Console.WriteLine(userNames.Count);
            Console.WriteLine("Ravi".GetHashCode());
            Console.WriteLine("ravi".GetHashCode());
            foreach (string userName in userNames)
            {
                Console.WriteLine(userName);
            }
        }
    }
}