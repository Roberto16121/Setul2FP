using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti cele {0} numere:", n);
        int a, b;
        a = int.Parse(Console.ReadLine());
        bool crescator = true;
        for (int i = 1; i < n; i++)
        {
            b = int.Parse(Console.ReadLine());
            if (b < a)
                crescator = false;
        }
        Console.WriteLine(crescator ? "Sirul dat este crescator" : "Sirul dat nu este crescator");
    }
}