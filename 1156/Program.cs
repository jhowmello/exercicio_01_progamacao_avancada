// Sequencia s2 
using System;

class Program
{
    static void Main()
    {
        double S = 0.0;
        double numerador = 1.0;
        double denominador = 1.0;

        while (numerador <= 39)
        {
            S += numerador / denominador;
            numerador += 2;
            denominador *= 2;
        }

        Console.WriteLine("{0:F2}", S);
    }
}
