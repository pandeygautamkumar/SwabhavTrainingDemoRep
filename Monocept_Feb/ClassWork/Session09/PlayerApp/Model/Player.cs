using System;
using System.Runtime.InteropServices;

namespace PlayerApp.Model
{
    internal class Player:Object
    {
        private int id;
        private string name;
        private int age;
        private const int MIN_AGE = 18;
        public Player(int id,string name,int age)
        {
            
            this.id = id;
            this.name = name;
            this.age = age;
            
            Console.WriteLine("3 Params Constructor.");
           
        }
        public Player(int id,string name):this(id, name,MIN_AGE)
        {
            /*
            this.id = id;
            this.name = name;
            age = 18;
            */
            Console.WriteLine("2 Params Constructor.");
        }
        public Player WhoIsElder(Player secondPlayer)
        {
            if (this.age < secondPlayer.age)
                return secondPlayer;
            else
                return this;
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }
    }
}
