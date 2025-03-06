// Sequencia lJ 2

using System;

class Program
{
    static void Main()
    {
        // Loop para variar o valor de I de 1 até 9, incrementando de 2 em 2
        for (int i = 1; i <= 9; i += 2)
        {
            // Loop para variar o valor de J de 7 até 5, decrementando de 1 em 1
            for (int j = 7; j >= 5; j--)
            {
                // Imprime os valores de I e J conforme o formato solicitado
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}