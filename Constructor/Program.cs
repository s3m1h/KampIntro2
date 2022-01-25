
Customer customer1 = new Customer();
customer1.FirstName = "semih";
customer1.Id = 1;

Customer customer2 = new Customer(2,"ahmet","serin","adana");

class Customer
{
    public Customer()
    {

    }
    // default constructor
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName  = firstName;
        LastName = lastName;
        City = city;        
        Console.WriteLine("yapıcı blok calıstı");
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}

