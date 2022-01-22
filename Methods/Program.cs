// See https://aka.ms/new-console-template for more information
using Methods;

//Console.WriteLine("Hello, World!");

// methodlar
// tekrar tekrar kullanılabilirliği sağlayan ortamlar sağlar
// do not repeat yourself - Dry - clean code - best practice 

// product sınıfından 4 tane örnek oluşturuldu
Product urun1 = new Product();
Product urun2 = new Product();
Product urun3 = new Product();
Product urun4 = new Product();

urun1.Name = "redmi note 8 pro";
urun2.Name = "Awox B205800S 58” 147 Ekran Uydu Alıcılı 4K Ultra HD Android Smart LED TV'";
urun3.Name = "İmirket Balonpower Eğitici Oyuncak Seti";
urun4.Name = "Xiaomi Wicue 11” Lacivert LCD Dijital Çizim Tableti";

urun1.Fiyati = 3000;
urun2.Fiyati = 2000;
urun3.Fiyati = 80;
urun4.Fiyati = 50;


Product[] products = new Product[]
{
    urun1, urun2, urun3, urun4
};

// type-safe - tip güvenliği
foreach (Product product in products)
{
    Console.WriteLine(product.Name+ ": "+ product.Fiyati+"TL");
}


Console.WriteLine("------------------------------------Metodlar");
SepetManager sepetManager1 = new SepetManager();
// encapsulation kendimce tanımını yapacağım
// bir metod yazdık
// yani, benim bir ürünüm var ve sepete eklemek içinde bir ekle metodum var
// yapmak istediğim şu, eğer bir gün ürünüme yeni bir özellik eklersem sadece eklemiş olayım ve
// herhangi başka bir yerde değişiklik yapmak zorunda kalmayayım
// yani urun özelliklerini methoddan ayrı bir yerde tuttum direk ona vermek yerine
// ayrı bir classta tuttum
// ama bu methoda parametre olarak classı verdim
// bu şekilde kapsülleme yapmıs olduk

sepetManager1.Ekle(urun1);
sepetManager1.Ekle(urun2);
sepetManager1.Ekle(urun3);
sepetManager1.Ekle(urun4);


sepetManager1.Ekle2("elma","elma bir meyvedir",15);





