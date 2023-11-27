using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 2)
            return (n != 0 ? 1 : 0);
        else return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Al {0} termen din sirul Fibonacci este {1} ", n, Fibonacci(n));
    }
}