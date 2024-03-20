using System.Diagnostics.CodeAnalysis;
using System.Numerics;
public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++) {
            Console.WriteLine($"Data {i+1} berisi : {storedData[i]} yang disimpan pada waktu {inputDates[i]}");
        }
    }   
}



public class Penjumlahan<T>
{
    public T JumlahTigaAngka<T>(T param1, T param2, T param3) where T : IAdditionOperators<T, T, T>
    {
        return param1 + param2 + param3;
    }
}

class main
{
    public static void Main(string[] args)
    {
        Penjumlahan<double> penjumlahan = new Penjumlahan<double>();
        double angka1 = 13;
        double angka2 = 02;
        double angka3 = 22;
        Console.WriteLine(penjumlahan.JumlahTigaAngka(angka1, angka2, angka3));
        SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();
        int angka01 = 13;
        int angka02 = 02;
        int angka03 = 22;
        simpleDataBase.AddNewData(angka01);
        simpleDataBase.AddNewData(angka02);
        simpleDataBase.AddNewData(angka03);
        simpleDataBase.PrintAllData();
    }
}