using CollectionApp.Model;
using System;
using System.Collections;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            ArrayList dMartCard = new ArrayList();
            dMartCard.Add(new LineItem(1, "Milk Bikkied", 50, 2));
            dMartCard.Add(new LineItem(2, "Diary Milk", 100, 1));
            dMartCard.Add(new LineItem(3, "Drawing Book", 100, 3));

            PrintProductDetails(dMartCard);
        }

        private static void PrintProductDetails(ArrayList dMartCard)
        {
            double totalCost = 0;
            foreach (object item in dMartCard)
            {
                LineItem lineItem = (LineItem)item;
                Console.WriteLine($"{lineItem.Name} : {lineItem.Quantity} × {lineItem.UnitPrice} = {lineItem.ItemCost}");
                totalCost += lineItem.ItemCost;
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Total Cost : " + totalCost);
            Console.WriteLine("----------------------------------------------------------");
        }

        private static void CaseStudy1()
        {
            ArrayList dMartCard = new ArrayList();
            dMartCard.Add(new LineItem(1, "Milk Bikkied", 50, 2));
            dMartCard.Add(new LineItem(2, "Diary Milk", 100, 1));
            dMartCard.Add(new LineItem(3, "Drawing Book", 100, 3));
            //dMartCard.Add("vikrant");

            foreach (object item in dMartCard)
            {
                LineItem lineItem = (LineItem)item;
                Console.WriteLine(lineItem.Name);

                //LineItem lineItem=item as LineItem;     
                //if(lineItem!=null)
                //    Console.WriteLine(lineItem.Name);
            }
        }
    }
}