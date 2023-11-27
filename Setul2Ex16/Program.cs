using System;

class Program
{
    enum State
    {
        PrimulCrescator,
        Descrescator,
        AlDoileaCrescator
    }
    /// <summary>
    /// O secventa bitonica rotita este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive 
    /// (rotire = primul element devine ultimul).
    /// Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
    /// </summary>
    static void Main()
    {
        int n;
        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());
        int a, b;
        Console.WriteLine("Introduceti cele {0} numere", n);
        a = int.Parse(Console.ReadLine());
        int min = a, max = 0;
        bool rotita = false, ok = false;
        State state = State.PrimulCrescator;
        for(int i=1;i<n; i++)
        {
            b = int.Parse(Console.ReadLine());
            switch(state)
            {
                case State.PrimulCrescator:
                    if (a > b)
                    {
                        state = State.Descrescator;
                        ok = true;
                    }
                    break;
                case State.Descrescator:
                    if (a < b)
                    {
                        state = State.AlDoileaCrescator;
                        rotita = true;
                    }
                    break;
                case State.AlDoileaCrescator:
                    if (a > b)
                    {
                        Console.WriteLine("Secventa NU este una bitonica rotita");
                        return;
                    }
                    break;
            }
            a = b;
            max = b;
        }
        if(!ok)
        {
            Console.WriteLine("Secventa NU este o secventa bitonica rotita");
            return;
        }
        if(!rotita)
        {
            Console.WriteLine("Secventa este o secventa bitonica rotita");
            return;
        }
        if (min >= max)
            Console.WriteLine("Secventa este o secventa bitonica rotita");
        else Console.WriteLine("Secventa NU este o secventa bitonica rotita");
    }
}