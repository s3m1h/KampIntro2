// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


[ToTable("Customers")]
[ToTable("Customers")]
class Customer
{
    public int Id { get; set; }
    [RequiredProperty]
    public string FirstName { get; set; }
    [RequiredProperty]
    public string LastName { get; set; }
    [RequiredProperty]
    public int Age { get; set; }

}
class CustomerDal
{
    public void Add(Customer customer) {

        Console.WriteLine(customer.FirstName);
    }
}


[AttributeUsage(AttributeTargets.Property,AllowMultiple =false)]
class RequiredPropertyAttribute : Attribute
{

}
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
class ToTableAttribute: Attribute
{
    string _tableName;
    public ToTableAttribute(string tableName)
    {
        _tableName = tableName;
    }
}
