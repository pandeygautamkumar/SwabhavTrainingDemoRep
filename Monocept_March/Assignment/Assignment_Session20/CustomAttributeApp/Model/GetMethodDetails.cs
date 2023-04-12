using System;
using System.Reflection;

namespace CustomAttributeApp.Model
{
    internal class GetMethodDetails : Attribute
    {
        private string _description;
        public GetMethodDetails(string description)
        {
            _description = description;
        }

        public static void GetAllDetails(Type classType)
        {
            Console.WriteLine("Methods of Class {0}", classType.Name);

            MethodInfo[] methods = classType.GetMethods();

            foreach(var method in methods)
            {
                object[] attributesArray = method.GetCustomAttributes(true);
                
                foreach(Attribute item in attributesArray)
                {
                    if(item is GetMethodDetails)
                    {
                        GetMethodDetails methodDetails=(GetMethodDetails)item;
                        Console.WriteLine("{0} -{1}", method.Name, methodDetails._description);
                    }
                }
            }
        }

    }
}
