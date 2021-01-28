using FactoryPatternBestPractices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternBestPractices.Models
{
    public class Email : ISendMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email confirmation: {message}");
        }
    }
}
