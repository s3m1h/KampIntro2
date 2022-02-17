// C# ile kurumsal yazılım geliştirme teknikleri



// IoC Container, Ninject, AutoFac
CustomerManager customerManager = new CustomerManager(new NhCustomerDal(), new MainLoggerAdapter());
customerManager.Save(new Customer { FirstName="semih"});




class CustomerDal : ICustomerDal
{
    public void Add(Customer customer)
    {
        Console.WriteLine("Musteri Kaydedildi " + customer.FirstName);
    }
}
class NhCustomerDal : ICustomerDal
{
    public void Add(Customer customer)
    {
        Console.WriteLine("Musteri Kaydedildi " + customer.FirstName);
    }
}
internal interface ICustomerDal
{
    void Add(Customer customer); 
}

interface ICustomerService
{
    void Save(Customer customer);
}
class CustomerManager : ICustomerService
{
    ICustomerDal _customerDal;
    ILoggerService _loggerService;
    public CustomerManager(ICustomerDal customerDal, ILoggerService loggerService)
    {
        _customerDal = customerDal;
        _loggerService = loggerService;
    }

    public void Save(Customer customer)
    {
        // Kurallar
        // iş kodları
        // iş katmanı
        _customerDal.Add(customer);
        //Logger logger = new Logger();
        //logger.Log(LoggerType.Database);
        _loggerService.Log();
    }
}

class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
}
class Logger
{
    public void Log(LoggerType loggerType)
    {
        if(loggerType == LoggerType.Database)
        {
            Console.WriteLine("db kaydedildi...");
        }
    }
}
enum LoggerType
{
    Database,File
}
//----------------------------------------------
interface ILoggerService
{
    void Log();
}
class DatabaseLoggerManager : ILoggerService
{
    public void Log()
    {
        Console.WriteLine("Db Kaydedildi...");
    }
}
class FileLoggerManager : ILoggerService
{
    public void Log()
    {
        Console.WriteLine("File Kaydedildi...");
    }
}

class MainLoggerAdapter : ILoggerService
{
    public void Log()
    {
        MainLogger mainLogger = new MainLogger();
        mainLogger.LogToMain();
    }
}

// mikroservis
class MainLogger
{
    public void LogToMain()
    {
        Console.WriteLine("Log to main");
    }
}


