// Quadrado de pares
using System;

class Program
{
    static void Main()
    {
        // Lê o valor de N da entrada
        int N = int.Parse(Console.ReadLine());

        // Itera de 1 até N
        for (int i = 1; i <= N; i++)
        {
            // Verifica se o número é par
            if (i % 2 == 0)
            {
                // Calcula o quadrado do número par
                int quadrado = i * i;

                // Imprime o resultado no formato especificado
                Console.WriteLine($"{i}^2 = {quadrado}");
            }
        }
    }
}