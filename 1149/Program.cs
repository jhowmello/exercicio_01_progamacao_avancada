// Somando Inteiros Consecutivos

using System;

class Program
{
    static void Main()
    {
        int A, N;

        // Lê os valores A e N
        string[] input = Console.ReadLine().Split();
        A = int.Parse(input[0]);
        N = int.Parse(input[1]);

        // Enquanto N for menor ou igual a 0, leia um novo N
        while (N <= 0)
        {
            N = int.Parse(Console.ReadLine());
        }

        int soma = 0;

        // Soma A + i para cada i de 0 até N-1
        for (int i = 0; i < N; i++)
        {
            soma += A + i;
        }

        // Imprime o resultado
        Console.WriteLine(soma);
    }
}
