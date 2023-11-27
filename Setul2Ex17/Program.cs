using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti secventa de 0 si 1, fara spatiu intre cifre : ");
        string text = Console.ReadLine();

        int nivelMaxim = RezolvareParanteze(text);

        if (nivelMaxim != -1)
        {
            Console.WriteLine("Secventa este corecta si are nivelul maxim de încuibare: {0}", nivelMaxim);
        }
        else
        {
            Console.WriteLine("Secventa este incorecta.");
        }
    }

    static int RezolvareParanteze(string secventa)
    {
        int nivelCurent = 0;
        int nivelMaxim = 0;
        int zero = 0;
        foreach(char c in secventa)
        {
            if (c == '0')
            {
                zero++;
                nivelCurent++;
            }
            else if (c == '1')
            {
                zero--;
                nivelCurent--;
            }
            else
            {
                Console.WriteLine("Secventa contine caractere invalide.");
                return -1;
            }
            if(zero < 0)
                return -1;  
            if(nivelCurent > nivelMaxim)
                nivelMaxim = nivelCurent;
            
        }

        return nivelMaxim;

    }

   
}
