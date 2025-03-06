
using System;

class Program
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());

        if (X > Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }

        int soma = 0;

        for (int i = X + 1; i < Y; i++)
        {
            if (i % 2 != 0) 
            {
                soma += i;
            }
        }

        Console.WriteLine(soma);
    }
}