using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal interface IKrediManager
    {
        void Hesapla();
        void BirSeyYap();
    }
}
// 1- KrediManager ım classtı ve hesapla fonksiyonuna sahipti
// 2- KrediManager ı miras alan sınıflar bu hesapla fonksiyonunu farklı bir şekilde kullanacağından dolayı
// onu interface yaptık
// 3- KrediManager artık interface oldu
// 4- boylece onu miras alan KrediManagerların her biri kendi hesapla fonksiyonunu olusturdu
// 5- ve kendine göre değiştirecek
// 6- interface bizim için bir şablon görevi gördü
// 7- daha sonra Ikredimanager ın onu miras alan sınıfların referansını tutabildiğini öğrendim
// 8- örneğin: IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); bu şekilde bir kod
// halbuki bu kodu ihtiyackredimanager ile tanımlayabliyorduk bunun ne işimize yarayacağını sorguladım
// daha sonra bir kredi başvurusu yapma ihtiyacı duyduğumda ben istediğim kredi türünü seçebilmeliydim
// bunu yapabilmek içinde tüm kredi türleri kullanabilen IKrediManager vardı
// başvuruyaparken IkrediManager verdiğimde hem ihtiyaç hem taşıt hemde konut kredisi başvurusu yapabildim
// bu noktada interface olan IKrediManager ın diğer kredilerin referansını tutması benim için daha anlamlı bir hal aldı