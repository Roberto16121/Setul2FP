using System;

class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());
        int a, b;
        Console.WriteLine("Introduceti cele {0} numere", n);
        a = int.Parse(Console.ReadLine());
        bool cresc = true, desc = false, ok = true;
        for (int i = 1; i < n; i++)
        {
            b = int.Parse(Console.ReadLine());
            if (desc)
            {
                if (a < b)
                    ok = false;
            }
            if (a>b)
            {
                desc = true;
            }
            a = b;
        }
        Console.WriteLine(ok ? "Secventa este o secventa bitonica" : "Secventa NU este o secventa bitonica");

    }

}