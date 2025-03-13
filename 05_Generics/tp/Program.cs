using System;

class HaloGeneric
{
    public void Sapauser<T>(T user)
    {
        Console.WriteLine($"Halo Bro {user}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.Sapauser("Andera SInggih Pratama");
    }
}