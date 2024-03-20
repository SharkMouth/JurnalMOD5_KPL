using System.Diagnostics.CodeAnalysis;
using System.Numerics;

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
    }
}