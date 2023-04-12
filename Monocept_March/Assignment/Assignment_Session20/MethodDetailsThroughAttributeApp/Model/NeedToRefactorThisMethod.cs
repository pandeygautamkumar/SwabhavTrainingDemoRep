using System;
using System.Reflection;

namespace MethodDetailsThroughAttributeApp.Model
{
    internal class NeedToRefactorThisMethod : Attribute
    {
        public static void GetAllDetails(Type classType)
        {
            Console.WriteLine("Class : {0}", classType.Name);

            MethodInfo[] methods = classType.GetMethods();

            foreach (var method in methods)
            {
                object[] attributesArray = method.GetCustomAttributes(true);

                foreach (Attribute item in attributesArray)
                {
                    Console.WriteLine("-->"+method.Name);
                }
            }
        }
    }
}
