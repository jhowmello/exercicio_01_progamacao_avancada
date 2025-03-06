// Fatorial Simples 

using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        if (N > 0 && N < 13)
        {
            Console.WriteLine(Fatorial(N));
        }
    }

    static int Fatorial(int num)
    {
        int resultado = 1;
        for (int i = num; i > 1; i--)
        {
            resultado *= i;
        }
        return resultado;
    }
}