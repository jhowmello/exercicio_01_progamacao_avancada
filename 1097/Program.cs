// Sequencia lJ 3

using System;

class Program
{
    static void Main()
    {
        // Loop para variar o valor de I de 1 até 9, incrementando de 2 em 2
        for (int i = 1; i <= 9; i += 2)
        {
            // Calcula o valor inicial de J para o valor atual de I
            int jStart = 7 + (i - 1); // Ajuste para que J comece em 7, 9, 11, etc.

            // Loop para variar o valor de J de jStart até jStart - 2, decrementando de 1 em 1
            for (int j = jStart; j >= jStart - 2; j--)
            {
                // Imprime os valores de I e J conforme o formato solicitado
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}
