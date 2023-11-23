using System;

class Program
{
    static void Main() // Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
    {
        int n, poz = 0, neg = 0, zero = 0;
        Console.WriteLine("n=");
        n= int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                poz++;
            }
            else if (x < 0)
            {
                neg++;
            }
            else
            {
                zero++;
            }
        }
        Console.WriteLine($"is sir sunt {poz} numere pozitive, {neg} numere negative, {zero} zerouri");
    }
}