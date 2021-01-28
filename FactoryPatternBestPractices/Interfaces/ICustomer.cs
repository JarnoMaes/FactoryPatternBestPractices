namespace FactoryPatternBestPractices.Interfaces
{
    public interface ICustomer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Adress { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
    }
}