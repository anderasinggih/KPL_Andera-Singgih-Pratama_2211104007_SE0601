using System;
using System.Collections.Generic;

public class PusatDataSingleton
{
    private static PusatDataSingleton _instance;
    public List<string> DataTersimpan { get; private set; }

    // Konstruktor private
    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    // Method Singleton
    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            _instance = new PusatDataSingleton();
        }
        return _instance;
    }

    // Mengembalikan semua data
    public List<string> GetSemuaData()
    {
        return DataTersimpan;
    }

    // Menampilkan semua data
    public void PrintSemuaData()
    {
        if (DataTersimpan.Count == 0)
        {
            Console.WriteLine("Data kosong.");
        }
        else
        {
            foreach (var data in DataTersimpan)
            {
                Console.WriteLine(data);
            }
        }
    }

    // Menambahkan data baru
    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    // Menghapus data berdasarkan index
    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Index tidak valid!");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // A & B: Buat dua variabel singleton dan isi dari GetDataSingleton()
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // C: Tambah data anggota kelompok dan asisten praktikum ke data1
        data1.AddSebuahData("Andera Singgih pratama");
        data1.AddSebuahData("Rizky Hanifa");
        data1.AddSebuahData("Idham Cholid");
        data1.AddSebuahData("Fauzan Mubarak");
        data1.AddSebuahData("Imelda"); // Asisten praktikum
        data1.AddSebuahData("Naufal"); // Asisten praktikum

        // D: Print semua data dari data2
        Console.WriteLine("=== Data dari data2 ===");
        data2.PrintSemuaData();

        // E: Hapus nama asisten praktikum ("Imelda" dan "Naufal") dari data2
        int indexImelda = data2.GetSemuaData().IndexOf("Imelda");
        if (indexImelda != -1)
            data2.HapusSebuahData(indexImelda);

        int indexNaufal = data2.GetSemuaData().IndexOf("Naufal");
        if (indexNaufal != -1)
            data2.HapusSebuahData(indexNaufal);

        // F: Print data kembali dari data1 (harusnya Imelda & Naufal sudah tidak ada)
        Console.WriteLine("=== Data dari data1 setelah penghapusan Imelda & Naufal ===");
        data1.PrintSemuaData();

        // G: Print jumlah elemen di data1 dan data2
        Console.WriteLine($"Jumlah data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
    }
}