
Customer customer = new Customer();
customer.Id = 1;
customer.Name = "semih";
customer.LastName = "acar";
customer.City = "Adana";

List<Person> persons = new List<Person>();
persons.Add(customer);
persons.Add(new Customer { Name = "ahmet" });
persons.Add(new Customer { Name = "seda" });
persons.Add(new Person { Name = "barış" });
persons.Add(new Customer { Name = "ahmet" });
persons.Add(new Customer { Name = "ayşe" });
persons.Add(new Customer { Name = "fatma" });

foreach (var person in persons)
{
    Console.WriteLine(person.Name);
}

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }

}


class Customer : Person
{
    public string City { get; set; }
}

