using FactoryPatternBestPractices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternBestPractices.Models
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"We Logged following info: {message}");
        }
    }
}
