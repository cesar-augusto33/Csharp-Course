using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //usuário digita o tamanho do vetor.
            string[] name = new string[n]; //instancia o vetor para o tamanho digitado pelo usuário.
            int[] idade = new int[n]; //instancia o vetor para o tamanho digitado pelo usuário.

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' '); //usuário digita os valores do vetor.
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
