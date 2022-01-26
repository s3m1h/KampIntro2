using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        // elimizde tum kredilerin referansını tutabilen Ikredimanager vardı
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            krediManager.Hesapla();
            foreach (var log in loggerService)
            {
                log.Log();
            }
            // basvuran bilgilerini değerlendirme
            // aşağıdaki kodlar calısır fakat yanlış bir kullanım olur
            //KonutKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager1.Hesapla();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManagers)
        {
            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();
            }
        }

    }
}
