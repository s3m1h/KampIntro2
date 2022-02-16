// See https://aka.ms/new-console-template for more information
using CleanCodeDemo.Business;
using CleanCodeDemo.Concrete;

Console.WriteLine("Hello, World!");



IProductService productService = new ProductManager(new CentralBankManager());
productService.Sell(
    new CleanCodeDemo.Entities.Product {ProductId=1,Price=1500,ProductName="bilgisayar"},
    new CleanCodeDemo.Entities.Customer {Id=1, Name="semih",IsStudent=true},
    new CleanCodeDemo.Entities.Concrete.CurrencyRate { });

