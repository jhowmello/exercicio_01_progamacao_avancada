// Experiencias

using System;

class Program
{
    static void Main()
    {
        int totalCobaias = 0;
        int totalCoelhos = 0;
        int totalRatos = 0;
        int totalSapos = 0;

        // Lê o número de casos de teste
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            // Lê a quantidade e o tipo de cobaia
            string[] entrada = Console.ReadLine().Split(' ');
            int quantia = int.Parse(entrada[0]);
            char tipo = char.Parse(entrada[1]);

            // Atualiza o total de cobaias e o total de cada tipo
            totalCobaias += quantia;

            switch (tipo)
            {
                case 'C':
                    totalCoelhos += quantia;
                    break;
                case 'R':
                    totalRatos += quantia;
                    break;
                case 'S':
                    totalSapos += quantia;
                    break;
            }
        }

        // Calcula os percentuais
        double percentualCoelhos = (double)totalCoelhos / totalCobaias * 100;
        double percentualRatos = (double)totalRatos / totalCobaias * 100;
        double percentualSapos = (double)totalSapos / totalCobaias * 100;

        // Exibe os resultados
        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {totalCoelhos}");
        Console.WriteLine($"Total de ratos: {totalRatos}");
        Console.WriteLine($"Total de sapos: {totalSapos}");
        Console.WriteLine($"Percentual de coelhos: {percentualCoelhos:F2} %");
        Console.WriteLine($"Percentual de ratos: {percentualRatos:F2} %");
        Console.WriteLine($"Percentual de sapos: {percentualSapos:F2} %");
    }
}