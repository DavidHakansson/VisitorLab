using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_CSD
{
    class XMLVisitor : IVisitor
    {
        StringBuilder xml = new StringBuilder();

        public void Visit(Invoice invoice)
        {

            xml.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            xml.AppendLine("<invoice>");
            xml.AppendLine($"<invoiceDate>{invoice.InvoiceDate}</invoiceDate>");
            xml.AppendLine($"<customerNumber>{invoice.CustomerNumber}</customerNumber>");
            xml.AppendLine($"<invoiceNumber>{invoice.InvoiceNumber}</invoiceNumber>");
            xml.AppendLine($"<payByDate>{invoice.PayByDate}</payByDate>");
            xml.AppendLine("<lines>");

            foreach (InvoiceLine il in invoice.Lines)
            {
                il.Accept(this);
                
            }

            xml.AppendLine("</lines>");
            xml.AppendLine($"<total pre-tax='{invoice.PreTaxTotal}$' tax='{invoice.Tax}$' total='{invoice.Total}$'/>");
            xml.AppendLine("</invoice>");

            
            Console.WriteLine(xml.ToString());

        }

        public void Visit(InvoiceLine il)
        {
            xml.Append("<line");
            xml.Append($" qty='{il.QTY}'");
            il.Product.Accept(this);
            xml.Append($" total='{il.Total}$'");
            xml.AppendLine("/>");
        }
        public void Visit(Product p)
        {
            xml.Append($" productName='{p.ProductName}'");
            xml.Append($" unitPrice='{p.UnitPrice}$'");

        }
    }
}
