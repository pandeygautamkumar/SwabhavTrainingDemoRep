
using SRPViolationApp.Model;

namespace SRPRefectoredApp.Prasentation
{
    internal class InvoicePrinter
    {
        public void PrintInvoice(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string template = $"Id : {invoice.Id}  ,Desciption : {invoice.Description}" +
                 $" Cost is : {invoice.Cost}  Tax Amount is : {invoice.CalculateTax()}" +
                 $" Discount Amount is : {invoice.CalculateDiscount()}" +
                 $" Final Cost is :{invoice.FinalCost()} "
              ;
            Console.WriteLine(template);
            Console.ResetColor();
        }
    }
}
