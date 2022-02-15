// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Category> categories = new List<Category> { 
    new Category { CategoryId=1,CategoryName="bilgisayar"},
    new Category { CategoryId=2,CategoryName="telefon"},
};
List<Product> products = new List<Product> {
    new Product{Id=1,CategoryId=1,Name="acer",UnitPrice=12000,UnitsInStock=3},
    new Product{Id=2,CategoryId=1,Name="msi",UnitPrice=15000,UnitsInStock=1},
    new Product{Id=3,CategoryId=1,Name="asus",UnitPrice=16000,UnitsInStock=15},
    new Product{Id=4,CategoryId=2,Name="iphone",UnitPrice=5600,UnitsInStock=0},
    new Product{Id=5,CategoryId=2,Name="xioami",UnitPrice=3700,UnitsInStock=5000},
};

foreach (var product in products)
{
    if(product.UnitPrice > 5000)
    {
        Console.WriteLine(product.Name);
    }
    
}
Console.WriteLine("linq------------------------------");
var result = products.Where(p=>p.UnitPrice>5000);
foreach (var item in result)
{
    Console.WriteLine(item.Name);
}
class Product
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
