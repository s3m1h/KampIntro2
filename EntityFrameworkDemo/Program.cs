using EntityFrameworkDemo;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// ADO.NET
// Entity Framework -- ORM -- Object relational mapping
// NHibernate
// Dapper



// GetAll();
GetProductsByCategory(5);

void GetAll()
{
    NortwindContext nortwindContext = new NortwindContext();
    var result = nortwindContext.Products;
    foreach (var item in result)
    {
        Console.WriteLine(item.ProductName + " " + item.CategoryId);
    }
}

void GetProductsByCategory(int categoryId)
{
    NortwindContext nortwindContext = new NortwindContext();
    var query = from p in nortwindContext.Products
                join c in nortwindContext.Categories
                on p.CategoryId equals c.CategoryID
                select new { CategoryId= c.CategoryID , CategoryName = c.CategoryName,ProductName = p.ProductName };
    foreach (var item in query.Where(c=>c.CategoryId == categoryId))
    {
        Console.WriteLine("{0} {1}",item.CategoryName,item.ProductName);
    }

    //foreach (var item in nortwindContext.Products.Where(p=>p.CategoryId == categoryId))
    //{
    //    Console.WriteLine(item.ProductName + " " + item.CategoryId);
    //}
    
}



