using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_CSD
{
    interface IVisitor
    {
        public void Visit(Invoice invoice);
        public void Visit(InvoiceLine invoiceLine);
        public void Visit(Product product);
    }
}
