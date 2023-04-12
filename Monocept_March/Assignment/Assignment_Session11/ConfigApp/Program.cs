using ConfigApp.Model;
using System;
using System.Collections.Specialized;
using System.Configuration;
namespace ConfigApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            //CaseStudy3();
        }

        private static void CaseStudy3()
        {
            Config config = new Config();
            string[] connectionStrings = config.KeyValueStore();
            foreach (var connectionString in connectionStrings)
            {
                PrintDetails(connectionString);
            }
        }

        private static void CaseStudy2()
        {
            var appSettings = ConfigurationManager.GetSection("appSettings") as NameValueCollection;
            foreach (var key in appSettings.AllKeys)
            {
                PrintDetails(appSettings[key]);
            }
        }

        private static void CaseStudy1()
        {
            var connection1 = ConfigurationManager.AppSettings["connection1"];
            Console.WriteLine(connection1);
            var connection2 = ConfigurationManager.AppSettings["connection1"];
            Console.WriteLine(connection2);
        }
        private static void PrintDetails(string connectionString)
        {
            string[] names = connectionString.Split(';');
            //for (int i = 0; i < names.Length; i++)
            for (int i = 0; i <2; i++) 
            { 
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
