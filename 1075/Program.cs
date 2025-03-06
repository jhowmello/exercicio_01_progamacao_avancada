// Resto 2

using System;

class Program
{
    static void Main()
    {
        // Lê o valor de N
        int N = int.Parse(Console.ReadLine());

        // Verifica todos os números entre 1 e 10000
        for (int i = 1; i < 10000; i++)
        {
            if (i % N == 2) // Verifica se o resto da divisão por N é igual a 2
            {
                Console.WriteLine(i);
            }
        }
    }
}
