// See https://aka.ms/new-console-template for more information
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;




BaseCustomerManager starbucksCustomerManager = new StarbucksCustomerManager();
BaseCustomerManager neroCustomerManager = new NeroCustomerManager();

neroCustomerManager.Save(new Customer { FirstName="semih"});


