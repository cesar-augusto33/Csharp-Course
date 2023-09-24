using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] name = new string[n];
            int[] idade = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                name[i] = s[0];
                idade[i] = int.Parse(s[1]);
            }

            int maior = idade[0];
            int position = 0;
            for (int i = 0;i < n; i++)
            {
                if (idade[i] > maior)
                {
                    maior = idade[i];
                    position = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + name[position]);
        }
    }
}
