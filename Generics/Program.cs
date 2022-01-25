List<string> isimler = new List<string>();
isimler.Add("asf1");
isimler.Add("asf2");
isimler.Add("asf3");
Console.WriteLine(isimler.Count);


MyList<string> isimlerim = new MyList<string>();
isimlerim.Add("asef");
isimlerim.Add("asef1");
isimlerim.Add("asef2");
isimlerim.Add("asef3");
isimlerim.Add("asef4");
isimlerim.Add("asef5");
isimlerim.Add("asef6");
Console.WriteLine(isimlerim._Count);

class MyList<Typ>// Generic class
{
    Typ[] _array;
    Typ[] tempArray;
    public MyList()
    {
        _array = new Typ[0];
    }
    public void Add(Typ item)
    {

        tempArray = _array;
        _array = new Typ[_array.Length + 1];
        for (int i = 0; i < _array.Length-1; i++)
        {
            _array[i] = tempArray[i];
        }
        _array[_array.Length -1] = item;
    }
    public int _Count { 
        get { return _array.Length; } 
    }
}