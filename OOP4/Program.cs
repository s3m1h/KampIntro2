
using OOP4;
// camel case
//CustomerManager customerManager = new CustomerManager();
//customerManager.Add();

//ProductManager productManager = new ProductManager();
//productManager.Update();


Customer customer = new Customer();
// set işlemi
customer.Id = 1;
customer.FirstName = "semih";
customer.LastName = "acar";
customer.City = "adana";
// get işlemi
Console.WriteLine(customer.FirstName);

Customer customer2 = new Customer()
{
    Id = 2,
    FirstName = "engin",
    LastName = "demirog",
    City = "Diyarbakır"
};
Console.WriteLine(customer2.FirstName);


class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer eklendi.");
    }
    public void Update()
    {
        Console.WriteLine("Customer Update edildi.");
    }
}



