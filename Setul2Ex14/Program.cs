using System;
using System.IO;

class Program
{
    static void Main()
    {
        string numeFisier = "secventa.txt";
        Console.Write("Introduceti lungimea secventei: ");
        int n = int.Parse(Console.ReadLine());

        ScrieSecventaInFisier(numeFisier, n);
        Solve(numeFisier, n);
    }

    static void Solve(string numeFisier, int n)
    {
        int a, b;
        string newFile = "newFile.txt";
        
        for (int i = 0; i < n; i++)
        {
            using (StreamWriter sw = new StreamWriter(newFile))
            {
                int final;
                final = int.Parse(File.ReadLines(numeFisier).ElementAt(0));
                for (int j = 1; j < n; j++)
                {
                    b = int.Parse(File.ReadLines(numeFisier).ElementAt(j));
                    sw.WriteLine(b);
                }
                sw.WriteLine(final);
                sw.Close();
                if (VerifyMove(newFile, n, numeFisier))
                    return;
               
            }
        }
        Console.WriteLine("Secventa NU este o secventa monotona rotita");
    }
    static bool VerifyMove(string newFile, int n, string numeFisier)
    {
        int a, b;
        bool cresc = false, desc = false;
        a = int.Parse(File.ReadLines(newFile).ElementAt(0));
        for (int j = 1; j < n; j++)
        {
            b = int.Parse(File.ReadLines(newFile).ElementAt(j));
            if (a > b)
                desc = true;
            if (a < b)
                cresc = true;
            a = b;
        }
        if (cresc && !desc)
        {
            Console.WriteLine("Secventa este o secventa monotona rotita");
            return true;
        }
        else if (!cresc && desc)
        {
            Console.WriteLine("Secventa este o secventa monotona rotita");
            return true;
        }
        else
        {
            string text = File.ReadAllText(newFile);
            File.WriteAllText(numeFisier, text);
            File.Delete(newFile);
        }
        return false;
    }
    


    static void ScrieSecventaInFisier(string numeFisier, int n)
    {
        using (StreamWriter sw = new StreamWriter(numeFisier))
        {
            for (int i = 0; i < n; i++)
            {
                int numar = int.Parse(Console.ReadLine());
                sw.WriteLine(numar);
            }
        }
    }




}
