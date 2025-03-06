// Divisores

using System;

class Program
{
    static void Main()
    {
        // Lê o número inteiro N
        int N = int.Parse(Console.ReadLine());

        // Loop para encontrar e imprimir os divisores
        for (int i = 1; i <= N; i++)
        {
            if (N % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
