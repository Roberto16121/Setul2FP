using System;

class Program // 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
{
    static void Main()
    {
        int n;
        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());
        int nr = 0;
        bool inGrup = false;
        Console.WriteLine("Introduceti {0} numere", n);
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x != 0 && !inGrup)
            {
                inGrup = true;
            }
            if (x == 0 && inGrup)
            {
                nr++;
                inGrup = false;
            }                
        }
        if(inGrup)
            nr++;
        Console.WriteLine("Numarul de grupuri de numere este {0}", nr);
    }

}