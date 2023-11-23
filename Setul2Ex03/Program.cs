using System;

class Program
{
    static void Main() // Calculati suma si produsul numerelor de la 1 la n. 
    {
        int n, suma = 0;
        long produs = 1;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            suma += i;
            produs *= i;
        }
        Console.WriteLine($"Suma primelor {n} numere este {suma}");
        Console.WriteLine($"Produsul primelor {n} numere este {produs}");
    }
}