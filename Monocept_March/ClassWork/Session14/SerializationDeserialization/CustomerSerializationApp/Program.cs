using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CustomerLib.Model;

namespace CustomerSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer(103, "Gautam Pandey");
            FileStream fs = new FileStream("customer1.dump",FileMode.Create,FileAccess.Write);
            BinaryFormatter binaryFormatter=new BinaryFormatter();
            binaryFormatter.Serialize(fs,customer1);
            fs.Close();
            Console.WriteLine("Serialization Completed");
        }
    }
}
