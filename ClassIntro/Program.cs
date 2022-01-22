
Kurs kurs1 = new Kurs();
kurs1.KursAdi = "c#";
kurs1.KursEgitmen = "engin demiroğ";
kurs1.IzlenmeOrani = 68;
Console.WriteLine(kurs1.KursAdi);

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "python";
kurs2.KursEgitmen = "engin demiroğ";
kurs2.IzlenmeOrani = 608;
Console.WriteLine(kurs2.KursAdi);

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "java";
kurs3.KursEgitmen = "engin demiroğ";
kurs3.IzlenmeOrani = 8;
Console.WriteLine(kurs3.KursEgitmen + " : " + kurs3.KursAdi + " : " +kurs3.IzlenmeOrani);


Kurs kurs4 = new Kurs();
kurs4.KursAdi = "c++";
kurs4.KursEgitmen = "engin demiroğ";
kurs4.IzlenmeOrani = 800;
// pythonda liste olusturma su sekilde idi ->  liste = [1,2,3,4,5]
// c# da ise liste olusturma su sekilde -> int[] liste = new int[]{ 1,2,3,4,5};
// şimdi ise burada bir kurs classı olusturdum bunuda veri tipi kullanarak liste olusturabilirim
// su sekilde olacak -> Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
Kurs[] kurslar = new Kurs[] {
    kurs1,kurs2,kurs3,kurs4
};

foreach (var kurs in kurslar)
{
    Console.WriteLine("kursları bir listeye ekledim ve dongu ile donuyorum: " + kurs.KursAdi);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string KursEgitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}



