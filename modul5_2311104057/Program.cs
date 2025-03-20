class Penjumlahan
{
    // Method untuk menjumlahkan 3 angka
    public static T JumlahTigaAngka<T>(T a, T b, T c) where T : struct
    {
        dynamic hasil = a;
        hasil += b;
        hasil += c;
        return hasil;
    }
}
﻿class SimpleDataBase<T>
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
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int angka1 = 23; // 2 digit pertama NIM
        int angka2 = 11; // 2 digit kedua NIM
        int angka3 = 10; // 2 digit ketiga NIM

        var hasil = Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
        Console.WriteLine($"Hasil Penjumlahan: {hasil}");

        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(23);
        database.AddNewData(11);
        database.AddNewData(10);

        database.PrintAllData();
    }
}
