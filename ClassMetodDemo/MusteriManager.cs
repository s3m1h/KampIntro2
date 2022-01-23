using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri[] musteris,Musteri musteri)
        {
            musteris.Append(musteri);
            Console.WriteLine("Eklendi. "+musteri.Ad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Başarılı bir şekilde silindi." + musteri.KullaniciAdi);
        }
        public void Listele(Musteri[] musteris)
        {
            foreach (var musteri in musteris)
            {
                Console.WriteLine(
                    "İsim: "+musteri.Ad
                    +"\nSoyisim: "+musteri.Soyad
                    +"\nKullaniciAdi: "+musteri.KullaniciAdi
                    );
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
