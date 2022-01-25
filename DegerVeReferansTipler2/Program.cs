int sayi1 = 20;
int sayi2 = 10;
sayi1 = sayi2;

sayi2 = 200;
Console.Write(sayi1);

string[] isimler1 = new string[]
{
    "semih",
    "acar",
    "blablabla"
};

string[] isimler2 = new string[]
{
    "s",
    "a",
    "b"
};
isimler1 = isimler2;
isimler2[0] = "karpuz";

Console.WriteLine(isimler1[0]);
Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "semih";
person2.FirstName = "barış";

Employee employee1 = new Employee();
Customer customer = new Customer();

person1 = person2;
person2.FirstName = "kurtbar";
Console.WriteLine(person1.FirstName);

// customeer ve employe sınıflarına aynı zamanda person dediğim icin 
// persona customer ataması yapmamda herhangi bir sorun cıkmadı
Person person3 = customer;
Person person4 = employee1;


customer.FirstName = "demet";
customer.CredyCardNumber = "123123123";
Console.WriteLine(person3.FirstName);
Console.WriteLine(((Customer)person3).CredyCardNumber); //boxing
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
// base class
// person sınıfına onu miras alan sınıfların referanslarını atayabiliriz
// ornegin person1 = customer1
class Customer:Person
{
    public string CredyCardNumber { get; set; }
}
class Employee:Person
{
    public int EmployeeNumber { get; set; }
}





