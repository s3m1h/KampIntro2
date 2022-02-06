

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new Customer { FirstName = "semra"});
ProductManager productManager = new ProductManager();
productManager.Add();


Customer customer1 = new Customer();
// bir sınıfın özelliği eşittir dediğimiz zaman 'set' bloğu çalısıyor
// esittir demeden kullanırsak 'get' bloğu calısır.
customer1.Id = 1;
customer1.FirstName = "semih";
customer1.LastName = "acar";
customerManager.Add(customer1);
Customer customer2 = new Customer
{
    Id = 2,
    FirstName ="string",
};
