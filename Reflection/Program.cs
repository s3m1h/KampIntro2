
//DortIslem dortIslem = new DortIslem(5,7);
//var topla = dortIslem.Topla(2,4);
//var carp = dortIslem.Carp(5,2);
//Console.WriteLine(topla);
//Console.WriteLine(carp);

var type = typeof(DortIslem);
Console.WriteLine(type);
// DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,4,3); // calısma anında dorislemi newlemiş oluyoruz.
// Console.WriteLine(dortIslem.Topla(5, 4));
// Console.WriteLine(dortIslem.Topla2());

var ornek = Activator.CreateInstance(type, 4, 3);
Console.WriteLine(ornek);
var result = ornek.GetType().GetMethod("Topla2").Invoke(ornek,null); // bilgi alma 
Console.WriteLine(result);

class DortIslem
{
    int _sayi1, _sayi2;
    public DortIslem(int sayi1, int sayi2)
    {
        _sayi1 = sayi1;
        _sayi2 = sayi2;
    }
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public int Carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }
    public int Topla2()
    {
        return _sayi1 + _sayi2;
    }
    public int Fark()
    {
        return _sayi1 - _sayi2;
    }
}