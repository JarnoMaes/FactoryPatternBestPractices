using FactoryPatternBestPractices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternBestPractices.Models
{
    public static class Factory
    {
        public static ICustomer GetCustomer()
        {
            return new Customer();
        }
        
        public static ISendMessage GetEmail()
        {
            return new Email();
            //return new SMS();
        }
        //public static ISendMessage GetSMS()
        //{
        //    return new SMS();
        //}

        public static ILogger GetLogger()
        {
            return new Logger();
        }
        public static IOrder GetOrder()
        {
            return new Order(GetEmail(), GetLogger());
        }
    }
}
