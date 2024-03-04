using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_CSD
{
    class ConsoleVisitor : IVisitor
    {

        public void Visit(Invoice invoice)
        {
            Console.WriteLine("Invoice              Date: " + invoice.InvoiceDate.ToString());
            Console.WriteLine();
            Console.WriteLine("Customer number: " + invoice.CustomerNumber);
            Console.WriteLine("Invoice number: " + invoice.InvoiceNumber);
            Console.WriteLine("Payment by: " + invoice.PayByDate.ToString());
            Console.WriteLine();
            Console.WriteLine("Qty  Product                 Unit Price  Total");
            foreach(InvoiceLine il in invoice.Lines)
            {
                il.Accept(this);
            }
            Console.WriteLine();
            Console.WriteLine("Pre-tax total:"+invoice.PreTaxTotal+"$");
            Console.WriteLine("Tax(10%): " + invoice.Tax + "$");
            Console.WriteLine("Total: " + invoice.Total + "$");
        }
        public void Visit(InvoiceLine il)
        {
            Console.Write(il.QTY);
            il.Product.Accept(this);
            Console.Write(il.Total + "$");
            Console.WriteLine();
        }
        public void Visit(Product p)
        {
            Console.Write("    " + p.ProductName + "         "+ p.UnitPrice + "$      ");
        }
    }
}
