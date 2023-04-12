using GenericCollectionApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<LineItem> dMartCard = new List<LineItem>();
            dMartCard.Add(new LineItem(1, "Milk Bikkied", 50, 2));
            dMartCard.Add(new LineItem(2, "Diary Milk", 100, 1));
            dMartCard.Add(new LineItem(3, "Drawing Book", 100, 3));

            PrintProductDetails(dMartCard);
        }
        private static void PrintProductDetails(List<LineItem> dMartCard)
        {
            double totalCost = 0;
            foreach (LineItem item in dMartCard)
            { 
                Console.WriteLine($"{item.Name} : {item.Quantity} × {item.UnitPrice} = {item.ItemCost}");
                totalCost += item.ItemCost;
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Total Cost : " + totalCost);
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}