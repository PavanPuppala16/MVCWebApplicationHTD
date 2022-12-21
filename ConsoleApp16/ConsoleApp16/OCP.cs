using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{

    public interface IInvoice
    {
        double Calculate(double amount);
    }

    public class Invoice : IInvoice
    {

        public double Calculate(double amount)
        {
            Console.WriteLine("hi pavan");
            return amount + 10;
        }
    }

    public class DiscountInvoice : IInvoice
    {
        public double Calculate(double amount)
        {
            Console.WriteLine("hi pavan kumar");
            return amount - 10;
        }
        public class InvoiceModel
        {
            public int Id { get; set; }
            public string Type { get; set; }
            public double Amount { get; set; }
        }

        
    }
}