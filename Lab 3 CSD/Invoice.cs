using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_CSD
{
    class Invoice : IElement
    {
        public static int InvoicesCreatedNumber = 0000;

        private List<InvoiceLine> lines = new List<InvoiceLine>();
        private DateTime invoiceDate;
        private DateTime payByDate;
        private int customerNumber;
        private int invoiceNumber;

        private double preTaxTotal;
        private double tax;
        private double total;

        public List<InvoiceLine> Lines{ get => lines; }
        public DateTime InvoiceDate { get => invoiceDate; }
        public DateTime PayByDate { get => payByDate; }
        public int CustomerNumber { get => customerNumber; }
        public int InvoiceNumber { get => invoiceNumber; }

        public double PreTaxTotal { get => preTaxTotal; }
        public double Tax { get => tax; }
        public double Total { get => total; }



        public Invoice(int customerNumber)
        {
            this.customerNumber = customerNumber;

            this.invoiceNumber = InvoicesCreatedNumber;
            InvoicesCreatedNumber++;

            this.invoiceDate = System.DateTime.Today;
            this.payByDate = InvoiceDate.AddDays(30);
            
        }

        public void AddLine(Product p, int QTY)
        {
            Lines.Add(new InvoiceLine(QTY, p));


            foreach (InvoiceLine il in Lines)
            {
                total = total + il.Total;
            }

            tax = total * 0.1;
            preTaxTotal = total - tax;

        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }



    }
}
