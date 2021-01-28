using FactoryPatternBestPractices.Models;

namespace FactoryPatternBestPractices.Interfaces
{
    public interface IOrder
    {
        string Article { get; set; }
        decimal Price { get; set; }
        int Amount { get; set; }
        ICustomer Customer { get; set; }
        void OrderConfirmation();
    }
}