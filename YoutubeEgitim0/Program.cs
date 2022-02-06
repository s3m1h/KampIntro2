

int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2;
sayi2 = 100;
Console.WriteLine(sayi1);


int[] sayilar1 = new int[] { 1, 2, 3, 4, };
int[] sayilar2 = new int[] { 10, 20, 30, 50, };
sayilar1 = sayilar2;
sayilar2[0] = 1000;
Console.WriteLine(&sayilar1[0]);
