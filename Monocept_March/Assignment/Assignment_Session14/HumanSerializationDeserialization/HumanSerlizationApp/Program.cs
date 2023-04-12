using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using HumanLib.Model;

namespace HumanSerlizationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[5];
            humans[0] = new Human("Gautam",23,167.5,53.2);
            humans[1] = new Human("Ravi", 24, 169, 58);
            humans[2] = new Human("Rahul", 22, 165.5, 50.2);
            humans[3] = new Human("Raj", 26, 169.5, 55.2);
            humans[4] = new Human("Shyam", 28, 171.5, 60.2);

            humans[1].WorkOut();
            humans[1].WorkOut();
            humans[1].WorkOut();
            humans[1].WorkOut();
            humans[1].Eat();

            Console.WriteLine("Before Serialization.");
            Console.WriteLine();
            foreach (Human human in humans)
            {
                PrintDetails(human);
            }

            FileStream fs = new FileStream("human1.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs,humans);
            fs.Close();
            Console.WriteLine("Serialization Completed");
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
