using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // kurumsal
    // miras alma
    internal class CoorporateCustomer:Customer
    {
        public string CompanyName { get; set; } // şirket adı
        public string VergiNo { get; set; }
    }
}
