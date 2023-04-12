using CustomerLib.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VishakDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\SwbhavLiveSessions\\MonoceptMarch\\Session14\\VishakDeserializationApp\\bin\\Debug\\customer1.dump";
            FileStream fs = new FileStream(, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Object obj = binaryFormatter.Deserialize(fs);
            Customer customer = obj as Customer;
            Console.WriteLine("Customer Id : " + customer.Id);
            Console.WriteLine("Customer Name : " + customer.Name);
            fs.Close();
        }
    }
}
