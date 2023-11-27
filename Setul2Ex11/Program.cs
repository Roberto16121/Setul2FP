using System;

class Program
{
    static int Invers(int n)
    {
        int invers = 0;
        while (n != 0)
        {
            invers = invers * 10 + n % 10;
            n /= 10;
        }
        return invers;
    }

    static void Main()
    {
        int n;
        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());
        int suma = 0;
        Console.WriteLine("Introduceti {0} numere: ", n);
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            suma += Invers(x);
        }
        Console.WriteLine("Suma inverselor este {0}", suma);
    }
}