using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti un numar a=");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti cele {0} numere:", n);
        int index = -1;
        for (int i = 0; i < n; i++)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            if(x == a)
                index = i;
                
        }
        if(index == -1)
        {
            Console.WriteLine("Numarul {0} nu se gaseste in lista", a);
        }
        else
        {
            Console.WriteLine("Numarul {0} se gaseste in lista pe pozitia {1}", a, index);
        }
    }
}