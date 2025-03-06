// oma de Ímpares Consecutivos III

using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // Lê a quantidade de casos de teste

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split();
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);

            int sum = 0;
            int count = 0;

            // Verifica se X é ímpar, caso contrário começa do próximo número ímpar
            if (X % 2 == 0)
                X++;

            // Soma os Y números ímpares consecutivos a partir de X
            while (count < Y)
            {
                sum += X;
                X += 2; // Próximo número ímpar
                count++;
            }

            Console.WriteLine(sum); // Imprime a soma para o caso de teste atual
        }
    }
}
