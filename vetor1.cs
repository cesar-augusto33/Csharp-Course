using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            string[] s = Console.ReadLine().Split(' ');

            double maior = 0;
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(s[i]);

                if (numbers[i] > maior)
                {
                    maior = numbers[i];
                    cont = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(cont);
        }
    }
}
