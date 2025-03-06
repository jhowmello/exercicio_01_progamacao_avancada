// Sequencia s = 1 + 1/2 + 1/3 + 1/4 + ... + 1/100

using System;

class Program
{
    static void Main()
    {
        double S = 0.0;

        for (int i = 1; i <= 100; i++)
        {
            S += 1.0 / i;
        }

        Console.WriteLine("{0:F2}", S);
    }
}

