using CleanCodeDemo.Entities;
using CleanCodeDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Business
{
    public interface IProductService
    {
        void Sell(Product product, Customer customer,CurrencyRate currencyRate);

    }
}
