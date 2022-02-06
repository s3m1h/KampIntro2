//Customer customer1 = new Customer();
//customer1.Id = 1;
//customer1.City = "adana";

//Company company1 = new Company();
//company1.CompanyName = "vodafone";
//company1.VergiNo = "123123123";
//---------------------------------------

//Customer customer2 = new Company
//{
//    CompanyName = "turkcell",
//    VergiNo = "12121212",

//};
//Customer customer3 = new Person
//{
//    Id = 1,
//    City = "adana"
//};
//CustomerManager customerManager = new CustomerManager(customer2);
//customerManager.Add();
//-------------------------------------------------------------------

ICreditManager creditManager1 = new MilitaryCreditManager();
ICreditManager creditManager2 = new TeacherCreditManager();

CustomerManager customerManager = new CustomerManager();
customerManager.GiveCredit(creditManager1);





class Customer
{
    public int Id { get; set; }
    public string City { get; set; }


}
class Company:Customer
{
    public string CompanyName { get; set; }
    public string VergiNo { get; set; }
}
class Person : Customer
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string TcKimlikNo { get; set; }
}
interface ICreditManager
{
    void Hesapla();
    void Save();
}
class TeacherCreditManager : ICreditManager
{
    public void Hesapla()
    {
        Console.WriteLine("ogretmen kredisi hesaplandı");
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}
class MilitaryCreditManager : ICreditManager
{
    public void Hesapla()
    {
        Console.WriteLine("asker kredisi hesaplandı");
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}
class CustomerManager
{
    public CustomerManager()
    {

    }
    public void GiveCredit(ICreditManager creditManager)
    {
        creditManager.Hesapla();
    }
}
//class CustomerManager
//{
//    // private sadece bu sınıf icerisinde erişilebilir
//    private Customer _customer;
//    public CustomerManager(Customer customer)
//    {
//        _customer = customer;
//    }
//    public void Add()
//    {
//        Console.WriteLine(" Musteri Eklendi. ");
//    }
//    public void Delete()
//    {
//        Console.WriteLine("Musteri Silindi");
//    }
//}