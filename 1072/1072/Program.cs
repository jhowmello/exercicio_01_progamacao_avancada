using System;
// intervalo 2
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // Lê o valor de N
        int dentro = 0, fora = 0;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine()); // Lê cada valor X

            if (x >= 10 && x <= 20)
                dentro++;
            else
                fora++;
        }

        Console.WriteLine($"{dentro} in");
        Console.WriteLine($"{fora} out");
    }
}
