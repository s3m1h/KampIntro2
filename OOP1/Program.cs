using OOP1;

Product product1 = new Product();

product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "masa";
product1.UnitPrice = 200;


Product product2 = new Product
{
    Id = 2,
    CategoryId = 3,
    ProductName = "sandalye",
    UnitPrice = 300,
    UnitInStock = 5
};
// PascalCase
// camelCase
// case sensitive
ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);

    