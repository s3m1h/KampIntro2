// See https://aka.ms/new-console-template for more information
using ClassMetodDemo;
//Console.WriteLine("Hello, World!");

Musteri musteri1 = new Musteri();
Musteri musteri2 = new Musteri();
Musteri musteri3 = new Musteri();
Musteri musteri4 = new Musteri();

musteri1.Ad = "semih";
musteri2.Ad = "barış";
musteri3.Ad = "erkan";
musteri4.Ad = "ibrahim";

musteri1.Soyad = "acar";
musteri2.Soyad = "kurt";
musteri3.Soyad = "taş";
musteri4.Soyad = "büyükdemir";

musteri1.KullaniciAdi = "smhacar";
musteri2.KullaniciAdi = "kurtbar07";
musteri3.KullaniciAdi = "taşerkan";
musteri4.KullaniciAdi = "ibhmbüyükdemir";

Musteri[] musteris = new Musteri[] {musteri1,musteri2,musteri3};
MusteriManager yonetici = new MusteriManager();

yonetici.Ekle(musteris,musteri4);
yonetici.Listele(musteris);
yonetici.Sil(musteri2);
