using InterfacePolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Boy boy = new Boy();

            AtThePartyHall(man);
            AtThePartyHall(boy);
            //AtTheCinemaHall(man);
            AtTheCinemaHall(boy);
        }
        public static void AtTheCinemaHall(IEmotionable obj)
        {
            Console.WriteLine("At The Cinema Hall.");
            obj.Cry();
            obj.Laught();
            Console.WriteLine("Cinema End.");
            Console.WriteLine();
        }
        public static void AtThePartyHall(IMannerable obj)
        {
            Console.WriteLine("At The Party Hall.");
            obj.Wish();
            obj.Depart();
            Console.WriteLine("Party End.");
            Console.WriteLine();
        }
    }
}
