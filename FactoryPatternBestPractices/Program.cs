using FactoryPatternBestPractices.Interfaces;
using FactoryPatternBestPractices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternBestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            ICustomer customer = Factory.GetCustomer();
            customer.FirstName = "Jarno";
            customer.LastName = "Maes";
            customer.Adress = "Eggestraat 2";
            customer.Email = "jarno.maes@outlook.com";
            customer.PhoneNumber = "0486345702";

            IOrder order = Factory.GetOrder();
            order.Article = "Table";
            order.Amount = 1;
            order.Price = 125.25m;
            order.Customer = customer;
            order.OrderConfirmation();
        }
    }
}
