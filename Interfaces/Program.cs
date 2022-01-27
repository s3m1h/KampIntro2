




//IPersonManager personManager = new IPersonManager(); // hatalı, referans alamıyorum - newleyemiyorum

IPersonManager customerManager = new CustomerManager(); // başarılı
IPersonManager employeeManager = new EmployeeManager(); // başarılı



ProjectManager projectManager = new ProjectManager();
projectManager.Add(customerManager);
projectManager.Add(employeeManager);
projectManager.Update(employeeManager);


interface IPersonManager
{
    void Add();
    void Update();
}
// inherits - class
// implements - interface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri Eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Updated.");
    }
}
class EmployeeManager : IPersonManager
{
    public void Add()
    { 
        Console.WriteLine("Personel Eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Personel Updated.");
    }


}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
    public void Update(IPersonManager personManager)
    {
        personManager.Update();
    }
}


