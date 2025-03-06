// Número Primo

using System;

class Program
{
    // Função para verificar se o número é primo
    static bool EhPrimo(int x)
    {
        if (x <= 1)
            return false;
        for (int i = 2; i * i <= x; i++)
        {
            if (x % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        int N = int.Parse(Console.ReadLine()); // Lê o número de casos de teste

        // Processa cada caso de teste
        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine()); // Lê o número X

            // Verifica se X é primo e imprime o resultado
            if (EhPrimo(X))
                Console.WriteLine($"{X} eh primo");
            else
                Console.WriteLine($"{X} nao eh primo");
        }
    }
}
