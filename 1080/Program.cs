// Maior e posição  

using System;

class Program
{
    static void Main()
    {
        int maiorValor = int.MinValue; // Inicializa com o menor valor possível
        int posicao = 0;

        for (int i = 1; i <= 100; i++)
        {
            int valor = int.Parse(Console.ReadLine()); // Lê o valor

            if (valor > maiorValor)
            {
                maiorValor = valor;
                posicao = i;
            }
        }

        Console.WriteLine(maiorValor);
        Console.WriteLine(posicao);
    }
}
