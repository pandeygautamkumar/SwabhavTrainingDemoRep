using MethodDetailsThroughAttributeApp.Model;
using System;

namespace MethodDetailsThroughAttributeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NeedToRefactorThisMethod.GetAllDetails(typeof(Foo));
            NeedToRefactorThisMethod.GetAllDetails(typeof(Bar));
        }
    }
}