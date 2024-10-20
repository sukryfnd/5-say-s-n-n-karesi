using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int b = int.Parse(Console.ReadLine());

        // Bölüm ve sıfıra bölme kontrolü
        Console.WriteLine(b != 0 ? "Bölüm: " + (a / b) : "Sıfıra bölünemez!");
    }