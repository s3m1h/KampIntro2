

AndoidPhone xioami = new AndoidPhone();
AndoidPhone huawei = new AndoidPhone();
AndoidPhone poco  = new AndoidPhone();

xioami.Name = "xioami";
huawei.Name = "huawei";
poco.Name = "poco";
poco.Price = 2500;

AndoidPhone[] phones = new AndoidPhone[] {xioami,huawei,poco };
foreach (var phone in phones)
{
    Console.WriteLine(phone.Name);
}
//-----------------------------------------------------------------



Kullanici kull1 = new Kullanici();
Kullanici kull2 = new Kullanici();
Kullanici kull3 = new Kullanici();
Kullanici kull4 = new Kullanici();

Kullanici[] kullanicilar = new Kullanici[] { kull1,kull2,kull3,kull4};
foreach (var kullanici in kullanicilar)
{
    
   
    Console.Write("Ad: ");
    kullanici.Ad = Console.ReadLine();

    Console.Write("Soyad: ");
    kullanici.Soyad = Console.ReadLine();

    Console.Write("Yas: ");
    kullanici.Sehir = Console.ReadLine();

    Console.Write("Sehir: ");
    kullanici.Yas = Console.ReadLine();
        if (kullanici.Ad == "" && kullanici.Yas == "" && kullanici.Sehir == "" && kullanici.Soyad == "")
        {
            Console.WriteLine("boş bırakılamaz...tekrar giriniz: ");
        }
        else
        {
            Console.WriteLine("girdiğiniz ad: " + kull1.Ad);
            Console.WriteLine("girdiğiniz soyad: " + kull1.Soyad);
            Console.WriteLine("girdiğiniz sehir: " + kull1.Sehir);
            Console.WriteLine("girdiğiniz yas: " + kull1.Yas);
            break;
        }
    
}



class AndoidPhone
{
    public string Image_Path { get; set; }
    public int Price { get; set; }
    public string Discount { get; set; }
    public string Name { get; set; }
    public string Star { get; set; }
    public string Color { get; set; }
    public string Capacity { get; set; }
    public string Ram { get; set; }


}

    
class Kullanici
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Yas { get; set; }
    public string Sehir { get; set; }

}