using System;

class Program
{
    static void Main()
    {
        Console.Write("Skriv in ett ord? ");
        string ord = Console.ReadLine();

        if (ord.Length > 9)
        {
            Console.WriteLine("Ordet får inte vara längre än 9 bokstäver.");
            return;
        }

        Console.Write("Hur många upprepningar vill du ha? ");
        int antalUpprepningar = int.Parse(Console.ReadLine());

        for (int i = 0; i < antalUpprepningar; i++)
        {
            Console.Write(ord);
        }
    }
}