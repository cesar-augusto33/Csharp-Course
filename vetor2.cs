using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //usuário digita o tamanho do vetor.
            string[] s = Console.ReadLine().Split(' '); //usuário digita os valores do vetor.
            int[] values = new int[n]; //instancia o vetor para o tamanho digitado pelo usuário.

            int soma = 0; //declaração da variável para contar a quantidade de números pares.
            for (int i = 0; i < n; i++) //armazenar todos os valores digitados para um vetor do tipo inteiro.
            {
                values[i] = int.Parse(s[i]);

                if (values[i] % 2 == 0) //verificação se o número, em cada posição do vetor, é par.
                {
                    Console.Write(values[i] + " "); //mostra na tela quais são os números pares.
                    soma++; //soma a quantidade de números pares.
                }
            }
            Console.WriteLine("\n" + soma); //mostra na tela quantidade de números pares.
        }
    }
}
