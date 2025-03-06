// Pum 


using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int valor = 1;
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"{valor} {valor + 1} {valor + 2} PUM");
            valor += 4;
        }
    }
}
