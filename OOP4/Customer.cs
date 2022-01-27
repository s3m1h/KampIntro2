using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Customer
    {
        // bir sınıfın ismi sadece customer, sadece product gibi isimlerden oluşuyorsa
        // bilmeliyimki o bir özellik barındıran bir sınıf
        // hemen customer özelliklerini tanımlıyorum
        
        // field
        public string isim;
        // property
        public int Id { get; set; }
        public string name;
        //public string FirstName { 
        //    get
        //    {
        //        return "Mr." + name;
        //    } 
        //    set
        //    {
        //        name = value;
        //    }
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        //// propfull
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}


    }
}
