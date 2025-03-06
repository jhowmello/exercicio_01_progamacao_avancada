using System;
class Uri1067
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());

        if (x <= x && x <= 1000)
        {
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}