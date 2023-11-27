using System;

class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());
        int a, b;
        bool crescator = false, descrescator = false;
        a = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            b = int.Parse(Console.ReadLine());
            if (b > a)
                crescator = true;
            if (b < a)
                descrescator = true;
            a = b;
        }
        Console.WriteLine(crescator && descrescator ? "Secventa data nu este monotona" : "Secventa data este monotona");
    }
}