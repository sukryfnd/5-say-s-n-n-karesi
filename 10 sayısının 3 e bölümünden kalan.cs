using System;

class Program
{
    static void Main()
    {
        int sayi = 10;
        int bolen = 3;

        int kalan = sayi % bolen;

        Console.WriteLine($"10 sayısının 3'e bölümünden kalan: {kalan}");
        Console.ReadKey();
    }
}