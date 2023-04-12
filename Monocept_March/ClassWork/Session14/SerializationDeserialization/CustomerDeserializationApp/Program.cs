using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CustomerLib.Model;

namespace CustomerDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "C:\\SwbhavLiveSessions\\MonoceptMarch\\Assignment\\Assignment_Session13\\SerializationDeserialization\\CustomerSerializationApp\\bin\\Debug\\customer1.dump";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter=new BinaryFormatter();
            Object obj=binaryFormatter.Deserialize(fs);
            Customer customer = obj as Customer;
            Console.WriteLine("Customer Id : " + customer.Id);
            Console.WriteLine("Customer Name : " + customer.Name);
            fs.Close();
        }
    }
}
