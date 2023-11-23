using System;

class Program
{

    static void Main() // Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
    {
        int n; 
        Console.WriteLine("n=");
        n = int.Parse(Console.ReadLine());
        int nrPare = 0;
        Console.WriteLine("Introduceti numerele:");
        for (int i = 0; i < n; i++)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                nrPare++;
            }
        }
        Console.WriteLine($"In sir sunt {nrPare} numere pare");
    }
}