//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

List<Category> categories = new List<Category> { 
    new Category { CategoryId=1,CategoryName="bilgisayar"},
    new Category { CategoryId=2,CategoryName="telefon"},
};
List<Product> products = new List<Product> {
    new Product{Id=1,CategoryId=1,Name="acer laptop",UnitPrice=12000,UnitsInStock=3},
    new Product{Id=2,CategoryId=1,Name="msi laptop",UnitPrice=15000,UnitsInStock=1},
    new Product{Id=3,CategoryId=1,Name="asus laptop",UnitPrice=16000,UnitsInStock=15},
    new Product{Id=4,CategoryId=2,Name="iphone",UnitPrice=5600,UnitsInStock=0},
    new Product{Id=5,CategoryId=2,Name="xioami",UnitPrice=3700,UnitsInStock=5000},
};
JoinLinqTest(products, categories);

static void JoinLinqTest(List<Product> products, List<Category> categories)
{
    var result = from p in products
                 join c in categories
                 on p.CategoryId equals c.CategoryId
                 select new ProductDto { ProductId = p.Id, ProductName = p.Name, CategoryName = c.CategoryName, UnitPrice = p.UnitPrice };


    foreach (var productDto in result)
    {
        Console.WriteLine("{0} --------- {1}",productDto.ProductName, productDto.CategoryName);
    }
}


static void ClassicLinqTest(List<Product> products) {
    // klasik linq kodları
    var result = from p in products
                 where p.UnitPrice > 6000
                 orderby p.UnitPrice
                 select new ProductDto { ProductId = p.Id, ProductName = p.Name };

    foreach (var product in result)
    {
        Console.WriteLine(product.ProductName);
    }
}

static void AscDescTest(List<Product> products){
    var result = products.Where(p => p.Name.Contains("lap")).OrderBy(p => p.UnitPrice);
    foreach (var product in result)
    {
        Console.WriteLine(product.Name);
    }
}

static void FindAllTest(List<Product> products)
{
    var result = products.FindAll(p => p.Name.Contains("i"));
    foreach (var item in result)
    {
        Console.WriteLine(item.Name);
    }
}
//contains - içeriyorsa anlamına gelir


//var result = products.Find(p=>p.Id==1);
//Console.WriteLine(result.Name);

//var result = products.Any(p=>p.Name == "msif"); // true veya false dönecektir
//Console.WriteLine(result);


//foreach (var product in products)
//{
//    if(product.UnitPrice > 5000)
//    {
//        Console.WriteLine(product.Name);
//    }

//}
//Console.WriteLine("linq------------------------------");
//var result = products.Where(p=>p.UnitPrice>5000);
//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}
class ProductDto // data transformation object
{
    public int ProductId { get; set; }
    public string CategoryName { get; set; }
    public string ProductName { get; set; }
    public int UnitPrice { get; set; }
}


class Product
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public int UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
