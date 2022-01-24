using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        // Encapsulation
        // özellikleri ayrı bir yerde tutmak
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi");
        }
        public void Delete(Product product)
        {

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }
        public void Read()
        {

        }
    }
}
