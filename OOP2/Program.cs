
using OOP2;

IndividualCustomer gercekMusteri1 = new IndividualCustomer();
gercekMusteri1.CustomerNumber = "123123123";
gercekMusteri1.FirstName = "semih";
CoorporateCustomer tuzelMusteri1 = new CoorporateCustomer();
gercekMusteri1.CustomerNumber = "4545454545";

// gercek customer - tuzel customer
// SOLID - L


// customer hem gerçek hemde kurumsal musterinin referansını tutabiliyor
// miras veren customer halbuki
Customer customer1 = new IndividualCustomer();
Customer customer2 = new CoorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(gercekMusteri1);
customerManager.Add(tuzelMusteri1); // yöneticiye müşteri gönderdim
customerManager.Add(customer1); // yöneticiye gerçek müşteri gönderdim
customerManager.Add(customer2); // yöneticiye tüzel müşteri gönderdim
