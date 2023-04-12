
using SRPViolationApp.Model;

namespace SRPRefectoredApp.Prasentation
{
    internal class InvoiceHtmlPrinter
    {
        public void PrintToHtml(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string template = $"Id : {invoice.Id}  ,Desciption : {invoice.Description}" +
                 $" Cost is : {invoice.Cost}  Tax Amount is : {invoice.CalculateTax()}" +
                 $" Discount Amount is : {invoice.CalculateDiscount()}" +
                 $" Final Cost is :{invoice.FinalCost()} "
              ;
            Console.WriteLine(template);
            Console.ResetColor();


            StreamWriter sw = new StreamWriter(invoice.Id+".html");
            sw.WriteLine("<html>");
            sw.WriteLine("<body>");
            sw.WriteLine("<h1>");
            sw.WriteLine(template);
            sw.WriteLine("</h1>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();
        }
    }
}
