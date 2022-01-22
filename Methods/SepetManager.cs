using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        // naming convention
        // syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine();
            Console.WriteLine("Sepete Eklendi. " +urun.Name);
        }

        // ustteki ekle medotuna product sınıfını direk olarak parametre verdik
        // ana programda urun örnepi olusturup parametre olarak kullanabiliriz
        // alttaki ekle2 metodunda ise product sınıfında olsturdugumuz özellikleri direkt parametre olarak gecirdik
        public void Ekle2(string urunAdi, string aciklama,int stokAdedi)
        {
            Console.WriteLine(urunAdi+" "+aciklama+" "+stokAdedi);
        }
    }
}
