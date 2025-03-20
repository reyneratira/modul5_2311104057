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

    static void Main()
    {
        int angka1 = 23; // 2 digit pertama NIM
        int angka2 = 11; // 2 digit kedua NIM
        int angka3 = 10; // 2 digit ketiga NIM

        var hasil = JumlahTigaAngka(angka1, angka2, angka3);
        Console.WriteLine($"Hasil Penjumlahan: {hasil}");
    }
}