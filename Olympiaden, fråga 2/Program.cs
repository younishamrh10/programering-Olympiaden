using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("N?");
        int N = int.Parse(Console.ReadLine());

        int count = 0;

        for (int a = 1; a < N; a++)
        {
            int product = a * (a + 1) * (a + 2);

            if (product < N)
            {
                count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"svar:{count}");
    }
}