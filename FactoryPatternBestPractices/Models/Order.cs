using FactoryPatternBestPractices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternBestPractices.Models
{
    public class Order : IOrder
    {
        public string Article { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public ICustomer Customer { get; set; }
        
        private readonly ISendMessage _sendMessage;
        private readonly ILogger _logger;
        

        public Order(ISendMessage sendMessage, ILogger logger)
        {
            this._sendMessage = sendMessage;
            this._logger = logger;
        }
        
        public void OrderConfirmation()
        {
            SendMessage($"We confirm that {Article} is delivered to {Customer.FirstName} {Customer.LastName} on {Customer.Adress}");
            Log($"{Article} bought by {Customer.FirstName} {Customer.LastName} on {DateTime.Now} and the value paid was {Price}");
        }
        private void SendMessage(string message)
        {
            //Email messenger = new Email();
            _sendMessage.SendMessage(message);
        }

        private void Log(string message)
        {
            //Logger logger = new Logger();
            _logger.Log(message);
        }
    }
}
