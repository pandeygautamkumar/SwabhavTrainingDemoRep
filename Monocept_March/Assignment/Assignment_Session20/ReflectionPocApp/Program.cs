
/*
Reflection is the process of describing the metadata of types, methods and fields in a code. 
The namespace System.Reflection enables you to obtain data about the loaded assemblies, 
the elements within them like classes, methods and value types.
*/

using System.Net.WebSockets;
using System.Reflection;

namespace ReflectionPocApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly executing = Assembly.GetExecutingAssembly();

            Type[] types=executing.GetTypes();

            foreach(var item in types)
            {
                Console.WriteLine("Class : {0}",item.Name);

                MethodInfo[] methods = item.GetMethods();
                foreach(var method in methods)
                {
                    Console.WriteLine("--> Method : {0}", method.Name);

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach(var arg in parameters)
                    {
                        Console.WriteLine("---> Parameter : {0} Type : {1}", arg.Name, arg.ParameterType);
                    }
                }
            }
        }
    }
}