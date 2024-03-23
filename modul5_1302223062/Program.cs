using System;
using System.Net.NetworkInformation;
using System.Numerics;

class SimpleDataBase <T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.storedData.Count; i++)
        {
            Console.WriteLine(storedData[i]);
        }
    }
}

class program
{
    static void Main(string[] args)
    {
        SimpleDataBase<float> data = new SimpleDataBase<float>();
        data.addNewData(13);
        data.addNewData(02);
        data.addNewData(22);

        data.PrintAllData();
    }
}