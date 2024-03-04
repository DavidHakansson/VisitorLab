using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_CSD
{
    class InvoiceLine : IElement
    {
        private int qty;
        private Product product;
        private int total;


        public int QTY { get => qty; }
        public Product Product { get => product; }
        public int Total { get => total; }

        public InvoiceLine(int qty, Product product)
        {
            this.product = product;
            this.qty = qty;
            this.total = qty * product.UnitPrice;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
