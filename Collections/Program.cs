

using System.Collections.Generic;

//string[] names = new string[] { "engin", "serkan", "semih", "barış" };
//Console.WriteLine(names[0]);
//Console.WriteLine(names[1]);
//Console.WriteLine(names[2]);
//Console.WriteLine(names[3]);


List<string> names1 = new List<string>(); // pythondaki names1 = list() kullanımı gibi düşünebilirim
List<string> names2 = new List<string> // bu satırıda yine pythondaki names2 = [a,b,c,d] gibi düşünebilirim
{
    "engin", "serkan", "semih","barış"
};
names1.Add("semih");
Console.WriteLine(names2[0]);
Console.WriteLine(names2[1]);
Console.WriteLine(names2[2]);
Console.WriteLine(names2[3]);

names2.Add("ilker");
Console.WriteLine(names2[4]);

