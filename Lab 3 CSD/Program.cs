using System;

namespace Lab_3_CSD
{
    class Program
    {
        static void Main(string[] args)
        {

            Invoice invoice = new Invoice(1);

            Product product2 = new Product("Ream of paper (500)", 5);
            Product product3 = new Product("Standard Fruit Laptop", 2000);
            Product product1 = new Product("Mythical Man-Month", 45);

            invoice.AddLine(product1, 10);
            invoice.AddLine(product2, 15);
            invoice.AddLine(product3, 20);

            ConsoleVisitor cv = new ConsoleVisitor();
            XMLVisitor xmlv = new XMLVisitor();     
            invoice.Accept(cv);
            invoice.Accept(xmlv);

        }
    }
}
