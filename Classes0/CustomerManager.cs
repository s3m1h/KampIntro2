

class CustomerManager
{
    public void Add(Customer customer)
    {
        Console.WriteLine("Customer Added. " + customer.FirstName);
    }
    public void Update(Customer customer)
    {
        Console.WriteLine("Customer Updated.");
    }
}
