using System;

class Program
{
    static void Main()
    {
        Console.Write("Dikdörtgenler prizmasının uzun kenarını girin: ");
        double uzunKenar = double.Parse(Console.ReadLine());

        Console.Write("Dikdörtgenler prizmasının kısa kenarını girin: ");
        double kisaKenar = double.Parse(Console.ReadLine());

        Console.Write("Dikdörtgenler prizmasının yüksekliğini girin: ");
        double yukseklik = double.Parse(Console.ReadLine());

        // Hacmi hesapla
        double hacim = uzunKenar * kisaKenar * yukseklik;

        Console.WriteLine($"Dikdörtgenler prizmasının hacmi: {hacim}");
        
    }
}