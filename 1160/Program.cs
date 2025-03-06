// Crescimento Populacional

using System;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine()); // Número de casos de teste

        for (int t = 0; t < T; t++)
        {
            // Leitura dos dados para cada caso de teste
            string[] inputs = Console.ReadLine().Split();
            int PA = int.Parse(inputs[0]);
            int PB = int.Parse(inputs[1]);
            double G1 = double.Parse(inputs[2]);
            double G2 = double.Parse(inputs[3]);

            int anos = 0;

            // Simula o crescimento ano a ano
            while (PA <= PB && anos <= 100)
            {
                PA = (int)(PA * (1 + G1 / 100)); // Atualiza população de A
                PB = (int)(PB * (1 + G2 / 100)); // Atualiza população de B
                anos++;
            }

            // Verifica o resultado
            if (anos > 100)
            {
                Console.WriteLine("Mais de 1 seculo.");
            }
            else
            {
                Console.WriteLine(anos);
            }
        }
    }
}
