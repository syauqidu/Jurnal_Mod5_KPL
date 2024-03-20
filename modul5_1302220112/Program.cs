using System;   

namespace  modul5_1302220112;

public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic dynamic = a;
        dynamic dynamic2 = b;
        dynamic dynamic3 = c;
        dynamic dynamic4 = dynamic + dynamic2 + dynamic3; 
        Console.WriteLine(dynamic4);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Penjumalah dari NIM 1302220112 = ");
        Penjumlahan penjumlahan = new Penjumlahan();
        float a = 13;
        float b = 22;
        float c = 20;
        penjumlahan.JumlahTigaAngka<float>(a, b, c);
    }
}