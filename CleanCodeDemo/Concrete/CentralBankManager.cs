using CleanCodeDemo.Abstract;
using CleanCodeDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Concrete
{
    public class CentralBankManager : IBankService
    {
        // encapsulation 
        // özellikleri ayrı bir sınıfta tuttuk
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal)13.62;
        }
    }
}
