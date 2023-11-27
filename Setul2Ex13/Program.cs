using System;

class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());
        int a, b, min = 0, max = 0;
        Console.WriteLine("Introduceti cele {0} numere", n);
        a = int.Parse(Console.ReadLine());
        bool prima = true, ok = true;
        min = a;
        for (int i = 1; i < n; i++)
        {
            b = int.Parse(Console.ReadLine());
            if(a > b)
            {
                if (prima)
                {
                    prima = false;
                }
                else ok = false;
            }
            if (!prima)
                max = b;
            a = b;
        }
        if(ok)
        {
            if(min >= max)
                Console.WriteLine("Secventa data este o secventa crescatoare rotita");
            else Console.WriteLine("Secventa data NU este o secventa crescatoare rotitae");
        }
        else Console.WriteLine("Secventa data NU este o secventa crescatoare rotita");
    }
}