// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IProductService productService = new ProductManager(new CentralBankManager());
productService.Sell(new Product { ProductId = 1, Price = 1500, ProductName = "bilgisayar" },
    new Customer { Id = 1, Name = "semih",});
interface IProductService
{
    void Sell(Product product, ICustomer customer);
}
class ProductManager : IProductService
{
    IBankService _bankService;

    public ProductManager(IBankService bankService)
    {
        _bankService = bankService;
    }

    public void Sell(Product product, ICustomer customer)
    {
        decimal price = product.Price;
        price = customer.GetPrice(price);
        price = _bankService.ConvertRate(new CurrencyRate { Price=1,Currency=price});
        Console.WriteLine(price);
    }
}

interface IBankService
{
    decimal ConvertRate(CurrencyRate currencyRate);
}
class CentralBankManager : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / (decimal)13.62;
    }
}
class MerkezBankasiSerivisiAdapter:IBankService
{

    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        MerkezBankasiServisi bankasiServisi = new MerkezBankasiServisi();
        return bankasiServisi.ConvertRate(currencyRate);
    }
}
class MerkezBankasiServisi
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / (decimal)10.62;
    }
}


interface IEntity
{

}
class CurrencyRate
{
    public decimal Price { get; set; }
    public decimal Currency { get; set; }
}
class Product : IEntity
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}
interface ICustomer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal GetPrice(decimal price);
}
class Customer : ICustomer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public decimal GetPrice(decimal price)
    {
        return price * (decimal)0.80;
    }
}
class Student : ICustomer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public decimal GetPrice(decimal price)
    {
        return price * (decimal)0.90;
    }
}

