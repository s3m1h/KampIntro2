

using OOP3;


// interface newlenemez bu yuzden alt satırdaki kod hata verecektir
//IKrediManager krediManager = new IKrediManager();

// interfaces - referans tutucu

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

IKrediManager tasitKrediManager = new TasitKrediManager();

IKrediManager konutKrediManager = new KonutKrediManager();

List<IKrediManager> krediManagers = new List<IKrediManager>() 
{ 
    ihtiyacKrediManager,
    tasitKrediManager,
    konutKrediManager
};


ILoggerService databaseService = new DatabaseLoggerService();
ILoggerService fileloggerService = new FileLoggerService();
ILoggerService smsloggerService = new SmsLoggerService();

List<ILoggerService> loggerServices = new List<ILoggerService>()
{
    databaseService,
    fileloggerService,
    smsloggerService
};

BasvuruManager basvuruManager1 = new BasvuruManager();
basvuruManager1.BasvuruYap(konutKrediManager, loggerServices);
//basvuruManager1.BasvuruYap(tasitKrediManager, loggerServices);
//basvuruManager1.BasvuruYap(ihtiyacKrediManager, loggerServices);

// #########  Yeni bir kredi türü eklediğimde veya yeni bir log servisi eklediğimde mevcut kodlarım bozulmasın  #########

IKrediManager esnafKrediManager = new EsnafKrediManager();
basvuruManager1.BasvuruYap(esnafKrediManager, loggerServices);
//basvuruManager1.KrediOnBilgilendirmesiYap(krediManagers);