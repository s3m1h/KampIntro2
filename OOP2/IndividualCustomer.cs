using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
     // sınıflar özellik(property) ve operasyonlar(method) tutar
     // özellik tuttuğumuz yerde method tutmuyoruz
     // method tuttugumuz yerde özellik tutmuyoruz

    // Bireysel
    // miras alma
    internal class IndividualCustomer:Customer
    {
        // gercek musteri özellikleri
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
    }
}
