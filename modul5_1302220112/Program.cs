using System;

namespace modul5_1302220112;

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase() {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    
    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < storedData.Count; i++) 
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

public class Program2
{
    public static void Main(string[] args)
    {
        SimpleDataBase<float> simpleDataBase = new SimpleDataBase<float>();
        simpleDataBase.addNewData(13);
        simpleDataBase.addNewData(22);
        simpleDataBase.addNewData(20);

        simpleDataBase.printAllData();
    }
}
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