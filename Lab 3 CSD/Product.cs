using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_CSD
{
    class Product
    {
        private string productName;
        private int unitPrice;

        public string ProductName { get => productName; }
        public int UnitPrice { get => unitPrice;}



        public Product(string productName, int unitPrice)
        {
            this.productName = productName;
            this.unitPrice = unitPrice;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
