using System;

class Program
{
    static void Main()
    {
        Console.Write("björns protin?");
        string protin = Console.ReadLine();

        Console.Write("K?");
        int k = int.Parse(Console.ReadLine());

        int minKlippningar = MinstaKlippningar(protein, k);

        Console.WriteLine($"Svar: {minKlippningar}");
    }

    string int  MinstaKlippningar(string protein, int k) 
    {
        int klippningar = 0;
        int consecutiveCount = 1;

        for(int i = 1; i < protein.Length; i++)
        {
            if (protein[i] == protein[i - 1])
            {
                consecutiveCount++;
                if (consecutiveCount > k)
                {
                    klippningar++;
                    consecutiveCount = 1;
                }
            }
            else
            {
                consecutiveCount = 1;
            }
        }
        return klippningar;
    }
}