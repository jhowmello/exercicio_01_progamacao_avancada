// Sequência Lógica 2

using System;

class Program
{
    static void Main()
    {
        // Lê os dois valores inteiros X e Y
        string[] input = Console.ReadLine().Split();
        int X = int.Parse(input[0]);
        int Y = int.Parse(input[1]);

        // Variável para controlar o número atual na sequência
        int current = 1;

        // Loop para gerar a sequência
        while (current <= Y)
        {
            // Imprimir até X números por linha
            for (int i = 0; i < X && current <= Y; i++)
            {
                // Imprime o número atual, sem espaço após o último número
                if (i == X - 1 || current == Y)
                {
                    Console.Write(current);
                }
                else
                {
                    Console.Write(current + " ");
                }
                current++;
            }

            // Pula para a próxima linha após imprimir X números
            Console.WriteLine();
        }
    }
}
