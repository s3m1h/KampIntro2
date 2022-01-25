

Dictionary<int,string> ogrenci = new Dictionary<int,string>();
ogrenci.Add(1, "ayşe");
ogrenci.Add(2, "mahmut");
ogrenci.Add(3, "osman");
Console.WriteLine("Dictionary count: "+ogrenci.Count);

MyDictionary<int,string> ogrenci2 = new MyDictionary<int, string>();
ogrenci2.Add(1, "semih");
ogrenci2.Add(1, "semih2");
ogrenci2.Add(1, "semih3");
Console.WriteLine("Mydictionary count: "+ogrenci2.Count);
//Console.WriteLine(ogrenci2.Count);
class MyDictionary<Tkey,Tvalue>
{
    Tkey[] keys;
    Tvalue[] values;
    public MyDictionary()
    {
        keys = new Tkey[0];
        values = new Tvalue[0];
    }

    public void Add(Tkey key, Tvalue value)
    {
        Tkey[] tempKey = keys;
        Tvalue[] tempValue = values;
        keys = new Tkey[keys.Length + 1];
        values = new Tvalue[values.Length + 1];
        for (int i = 0; i < keys.Length-1; i++)
        {
            keys[i] = tempKey[i];
        }
        for (int i = 0; i < values.Length-1; i++)
        {
            values[i] = tempValue[i];
        }
        keys[keys.Length - 1] = key;
        values[keys.Length - 1] = value;
    }
    public int Count { get
        {
            return keys.Length;
        }
    }

}