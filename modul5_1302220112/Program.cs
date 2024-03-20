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