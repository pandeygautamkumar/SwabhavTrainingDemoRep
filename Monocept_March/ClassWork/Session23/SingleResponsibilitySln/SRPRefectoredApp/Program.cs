using SRPRefectoredApp.Prasentation;
using SRPViolationApp.Model;

namespace SRPRefectoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Training Invoice", 100, .50);
            CaseStudy1(invoice);
            CaseStudy2(invoice);
        }

        private static void CaseStudy1(Invoice invoice)
        {
            InvoicePrinter invoicePrinter = new InvoicePrinter();
            invoicePrinter.PrintInvoice(invoice);
        }

        private static void CaseStudy2(Invoice invoice)
        {
            InvoiceHtmlPrinter invoiceHtmlPrinter = new InvoiceHtmlPrinter();
            invoiceHtmlPrinter.PrintToHtml(invoice);
        }
    }
}