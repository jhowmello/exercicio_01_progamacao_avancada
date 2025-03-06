// Quadrado e ao cubo

using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        if (N <= 1 || N >= 1000)
        {
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"{i} {i * i} {i * i * i}");
        }
    }
}