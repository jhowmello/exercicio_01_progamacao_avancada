// Sequência de Números e Soma

using System;

class Program
{
    static void Main()
    {
        int m, n;

        while (true)
        {
            string[] input = Console.ReadLine().Split();
            m = int.Parse(input[0]);
            n = int.Parse(input[1]);

            if (m <= 0 || n <= 0)
                break;

            int start = Math.Min(m, n);
            int end = Math.Max(m, n);

            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                Console.Write(i);
                sum += i;

                if (i < end)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine(" Sum = " + sum);
        }
    }
}
