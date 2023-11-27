using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        int a, min = int.MaxValue, max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            a = int.Parse(Console.ReadLine());
            if (a < min)
                min = a;
            if (a > max)
                max = a;
        }
        Console.WriteLine("Minimul din sir este {0} si maximul este {1}", min, max);
    }
}