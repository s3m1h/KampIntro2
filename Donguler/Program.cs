
string kurs1 = "yazılım geliştirici kampı";
string kurs2 = "java";
string kurs3 = "python";
// array - diziler

// bu tanım pythondaki liste = ["java", "python"] tanımıyla aynı
string[] kurslar = new string[] {
    "yazılım geliştirici kampı",
    "python",
    "java",
    "c#",
    "veri yapıları",
    "mikroişlemciler"
}; // string dizi tanımı yapıldı
string[] kurslar2 = new string[]
{
    "1",
    "2"
};
int[] sayilar = new int[]
{
    1,
    2,
    3,
    4
};
Console.WriteLine(kurslar[0]);
Console.WriteLine(kurslar[1]);
Console.WriteLine(kurslar[2]);
for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine("donguyle: " + kurslar[i]);
}
foreach (string kurs in kurslar)
{
    Console.WriteLine("foreach ile: " + kurs);
}

foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}



