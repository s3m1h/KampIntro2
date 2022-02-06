

abstract class MevzuatBase
{
    // abstract ile başlayan sınıflar 
    // ortak method veya ortak olmayan methodlar içerebilirler
    // ortaktan kastımız abstract sınıf bir method verir ve onu inherit eden sınıflar değiştiremeden aynı şeyi kullanırlar
    // ortak olmayan ise sadece imzası tanımlanmıştır methodun onu inherit edenler ise implement etmesi gerekir
    // cunku o methodu kendilerine göre dolduracaklardır.
    // bide abstract sınıflar referans vermiyor(yani newlenmiyor) aynı interface de oldugu gibi
    // ama onu inherit edenlerin referansını alabilir.
    // referans konusunda abstract class, normal class, interface bunlar onları inherit eden sınıfların referansını tutabiliyor
    // abstract sınıflar newlenemezmiş cunku icerisinde yarın method barındırdığı icin(sadece imza dediğimiz kısım)
    
    // abstract sınıflar constructor icerir. sınıfın kendisi newlenmiyor ama onu inherit alan newlendiğinde calısacaktır.
    // bir diğer konu ise abstract bir sınıfın constructor metodu public değilde protected olması gerektiği
    // 
    
    public abstract void Degerlendir();
    public void Kaydet()
    {
        Console.WriteLine("Kaydedildi");
    }
}
class AMevzuat : MevzuatBase
{
    public override void Degerlendir()
    {
        Console.WriteLine("A mevzuatına göre degerlendirildi");
    }
}
class BMevzuat : MevzuatBase
{
    public override void Degerlendir()
    {
        Console.WriteLine("B mevzuatına göre değerlendirildi");
    }
}

// somut sınıf dediğimiz bu
class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Added");
    }
    public void Delete()
    {
        Console.WriteLine("Deleted");
    }
    public void Update()
    {

    }
}
class Customer
{
    public int MyProperty { get; set; }
    public int MyProperty1 { get; set; }
    public int MyProperty2 { get; set; }

}