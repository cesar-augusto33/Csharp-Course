using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] i1 = new int[n];

            int sum = 0;
            int cont = 0;
            for (int i  = 0; i < n; i++)
            {
                i1[i] = int.Parse(s[i]);

                if (i1[i] % 2 == 0)
                {
                    sum += i1[i];
                    cont++;
                }
            }
            if (cont == 0)
            {
                Console.WriteLine("Nenhum número par digitado.");
            }
            else
            {
                double media = (double)sum / cont;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
