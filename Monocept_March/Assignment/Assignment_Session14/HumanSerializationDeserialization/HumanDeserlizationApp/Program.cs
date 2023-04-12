using HumanLib.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HumanDeserlizationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] humans;
            string path = "C:\\SwbhavLiveSessions\\MonoceptMarch\\Assignment\\Assignment_Session14\\HumanSerializationDeserialization\\HumanSerlizationApp\\bin\\Debug\\human1.dump";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            humans =(Human[]) binaryFormatter.Deserialize(fs);

            Console.WriteLine("After Deserlization");
            Console.WriteLine();
            foreach(Human human in humans)
            {
                PrintDetails(human);
            }
            fs.Close();
        }
        public static void PrintDetails(Human human)
        {
            Console.WriteLine("Name is : " + human.Name);
            Console.WriteLine("Age is : " + human.Age);
            Console.WriteLine("Height is : " + human.Height);
            Console.WriteLine("Weight is : " + human.Weight);
            Console.WriteLine("-----------------------------------");
        }
    }
}
