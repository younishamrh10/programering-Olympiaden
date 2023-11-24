using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("n?");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("m?");
        int m = int.Parse(Console.ReadLine());

        char[,] grid = new char[n, m];

        for (int i = 0; i <n; i++)
        {
            Console.WriteLine($"Rad {i + 1} ?");
            string row = Console.ReadLine();

            for (int j = 0; j < m; j++)
            {
                grid[i, j] = row[j];
            }
        }
        Console.Write("svar:");
        TraverseGrid(grid, n, m);
    }

    static void TraverseGrid(char[,] grid, int n, int m)
    {
        for(int i = 0; i < n; i++)
        {
            for(int j = 0;j < m; j++)
            {
                if (i + j == n - 1)
                {
                    Console.Write(grid[i, j]);
                }
            }
        }
        Console.WriteLine();
    }
}