using System;

class Program
{
    static void Main()
    {
        int n, nr = 0;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti cele {0} numere:", n);
        for (int i = 0; i < n; i++)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            if (i == x)
                nr++;
        }
        Console.WriteLine("In secventa data sunt {0} numere egale cu positia pe care apar", nr);

    }
}