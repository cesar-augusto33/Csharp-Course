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
            double[] d = new double[n];

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                d[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                soma += d[i];
            }
            double media = (double) soma / n;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0;i < n; i++)
            {
                if (d[i] < media)
                {
                    Console.WriteLine(d[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
