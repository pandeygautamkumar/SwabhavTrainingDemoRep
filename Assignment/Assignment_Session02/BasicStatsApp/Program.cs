using System;

namespace BasicStatsApp
{
    internal class Program
    {
        static void Main(string[] argumentList)
        {
            int count = argumentList.Length;
            int sum=0;
            int maximum= Convert.ToInt32(argumentList[0]);
            for (int i = 0; i < count; i++)
            {
                //int temp = int.Parse(argumentList[i]);
                int temp = Convert.ToInt32(argumentList[i]);
                sum +=temp;
                if (temp > maximum)
                {
                    maximum = temp;
                }
            }
            Console.WriteLine("Number of Element Will be : "+count);
            Console.WriteLine("Sum of All Element : "+sum);
            Console.WriteLine("Average of All Element : "+(sum/count));
            Console.WriteLine("Maximum Element Will be: "+ maximum);
        }
    }
}
