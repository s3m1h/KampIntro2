// See https://aka.ms/new-console-template for more information
using Project4.Business;
using Project4.DataAccess;

Console.WriteLine("Hello, World!");

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var item in productManager.GetAllProducts())
{
    Console.WriteLine(item.ProductName);
}

Console.WriteLine("--------------------------------------------");

PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
foreach (var item in personelManager.GetAll())
{
    Console.WriteLine(item.Name);
}