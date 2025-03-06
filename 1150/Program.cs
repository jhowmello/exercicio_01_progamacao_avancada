// Ultrapassando Z 

using System;

class Program
{
    static void Main()
    {
        // Lê o valor X
        int X = int.Parse(Console.ReadLine());

        // Lê o valor de Z
        int Z;
        while (true)
        {
            Z = int.Parse(Console.ReadLine());

            // Se Z for maior que X, sai do loop
            if (Z > X)
                break;
        }

        // Variáveis para controle da soma
        int soma = X;
        int contador = 1;

        // Soma os números subsequentes até a soma ultrapassar Z
        while (soma <= Z)
        {
            contador++;
            soma += (X + contador - 1); // Adiciona o próximo número na sequência
        }

        // Exibe o resultado final
        Console.WriteLine(contador);
    }
}
