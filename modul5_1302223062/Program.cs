using System;
using System.Net.NetworkInformation;
using System.Numerics;

class penjumlahan 
{
    public static T JumlahTigaAngka<T>(T satu, T Dua, T tiga) where T : IAdditionOperators<T,T,T>
    {
        return satu + Dua + tiga;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(JumlahTigaAngka<float>(13, 2, 22));
    }
}
