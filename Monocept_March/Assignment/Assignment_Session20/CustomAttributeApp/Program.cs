using CustomAttributeApp.Model;
using System.Linq.Expressions;

namespace CustomAttributeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee(1, "Gautam");
            GetMethodDetails.GetAllDetails(typeof(Employee));
        }
    }
}