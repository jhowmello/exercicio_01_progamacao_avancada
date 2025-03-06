// Soma de impares consecutivo 

using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split();
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);

            if (X > Y)
            {
                int temp = X;
                X = Y;
                Y = temp;
            }

            int somaImpares = 0;

            for (int j = X + 1; j < Y; j++)
            {
                // Verifica se o número é ímpar
                if (j % 2 != 0)
                {
                    somaImpares += j;
                }
            }

            Console.WriteLine(somaImpares);
        }
    }
}
