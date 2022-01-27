

//PersonManager personManager = new PersonManager();
//personManager.Add(new Customer { 
//    Id=2,
//    Name="barış",
//    Address="antalya"}
//);


//PersonManager personManager1 = new PersonManager();
//personManager1.Add(new Student { 
//    Id=1,
//    Name="semih",
//    OgrenciNo="123123123"}
//);
using OOP4._2_interfaces_;

ICustomerDal sqlServer = new SqlServerCustomerDal();
ICustomerDal postgresServer = new PostgresServerCustomerDal();
ICustomerDal oracleServer = new OracleServerCustomerDal();

//CustomerManager customerManager = new CustomerManager();
//customerManager.Add(sqlServer);
//customerManager.Add(postgresServer);
//customerManager.Add(oracleServer);


ICustomerDal[] customerDals = new ICustomerDal[] {
    sqlServer, postgresServer, oracleServer
};
foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

interface IPerson
{
    int Id { get; set; }
    string Name { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
class Student : IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string OgrenciNo { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.Name+" Added.");
    }
}
