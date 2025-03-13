using System;

class Program
{
    static void Main()
    {
        // Implementasi A: Menerima input nama praktikan
        Console.Write("Masukkan Nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!");

        // Implementasi B: Membuat array dengan 50 elemen sesuai index-nya
        int[] array = new int[50];
        for (int i=0;i<array.Length;i++)
        {
            array[i] = i;
            if (i%2==0&&i%3==0)
            {
                Console.WriteLine($"{i} #$#$");
            }
            else if(i%2==0)
            {
                Console.WriteLine($"{i} ##");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

        // Implementasi C: Memeriksa bilangan prima
        Console.Write("Masukkan sebuah angka (1-10000): ");
        int nilaiInt = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(nilaiInt))
        {
            Console.WriteLine($"Angka {nilaiInt} merupakan bilangan prima");
        }
        else
        {
            Console.WriteLine($"Angka {nilaiInt} bukan merupakan bilangan prima");
        }
    }

    // Fungsi untuk mengecek bilangan prima
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}