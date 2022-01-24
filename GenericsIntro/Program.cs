

using GenericsIntro;

List<string> isimler = new List<string>();

isimler.Add("semih");
isimler.Add("semih1");
isimler.Add("semih2");
isimler.Add("semi3");

foreach (var isim in isimler)
{
    Console.WriteLine(isim);
}


MyList<int> sayilar = new MyList<int>();
sayilar.Add(1);
sayilar.Add(2);
sayilar.Add(3);
sayilar.Add(4);
sayilar.Read();
