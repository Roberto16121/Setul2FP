using System;

class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());
        int a, b;
        int lenghtCurrent = 1, lenghtMax = 0;
        a = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            b = int.Parse(Console.ReadLine());
            if (b == a)
                lenghtCurrent++;
            else 
                lenghtCurrent = 1;
            if (lenghtCurrent > lenghtMax)
                lenghtMax = lenghtCurrent;
           

            a = b;
        }
        Console.WriteLine("Lungimea maxima a unei secvente crescatoare este {0}", lenghtMax);
    }
}