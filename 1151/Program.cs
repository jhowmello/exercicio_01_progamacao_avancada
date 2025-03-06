// Fibonacci Easy 

using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        if (N <= 0 || N >= 46)
            return;

        int a = 0, b = 1;

        for (int i = 0; i < N; i++)
        {
            if (i == N - 1)
                Console.Write(a);
            else
                Console.Write(a + " ");

            int temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine();
    }
}