// Par ou impar

using System;

class Program
{
    static void Main()
    {
        // Lê o número de casos de teste
        int N = int.Parse(Console.ReadLine());

        // Loop para processar cada caso de teste
        for (int i = 0; i < N; i++)
        {
            // Lê o valor X
            int X = int.Parse(Console.ReadLine());

            // Verifica se o valor é zero
            if (X == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                // Verifica se o valor é par ou ímpar
                if (X % 2 == 0)
                {
                    Console.Write("EVEN ");
                }
                else
                {
                    Console.Write("ODD ");
                }

                // Verifica se o valor é positivo ou negativo
                if (X > 0)
                {
                    Console.WriteLine("POSITIVE");
                }
                else
                {
                    Console.WriteLine("NEGATIVE");
                }
            }
        }
    }
}