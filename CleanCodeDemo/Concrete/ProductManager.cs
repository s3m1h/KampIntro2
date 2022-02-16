using CleanCodeDemo.Abstract;
using CleanCodeDemo.Concrete;
using CleanCodeDemo.Entities;
using CleanCodeDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Business
{
    public class ProductManager : IProductService
    {
        IBankService _bankService;

        public ProductManager(IBankService bankService)
        {
            _bankService = bankService;
        }

        public void Sell(Product product, Customer customer, CurrencyRate currencyRate)
        {
            decimal price = product.Price;
            if (customer.IsStudent)
            {
                price = product.Price * (decimal)0.90;
            }
            _bankService.ConvertRate(currencyRate);
        }
    }
}
