using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1 ,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("toplama işlemi sonucu: "+ toplam);
        }
        public void Cikarma(int sayi1, int sayi2)
        {
            int toplam = sayi1 - sayi2;
            Console.WriteLine("toplama işlemi sonucu: " + toplam);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int toplam = sayi1 * sayi2;
            Console.WriteLine("toplama işlemi sonucu: " + toplam);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            double toplam = sayi1 / sayi2;
            Console.WriteLine("toplama işlemi sonucu: " + toplam);
        }
    }
}
