using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s1 = Console.ReadLine().Split(' ');
            string[] s2 = Console.ReadLine().Split(' ');
            int[] i1 = new int[n];
            int[] i2 = new int[n];
            int[] i3 = new int[n];

            for (int i = 0; i < n; i++)
            {
                i1[i] = int.Parse(s1[i]);
                i2[i] = int.Parse(s2[i]);

                i3[i] = i1[i] + i2[i];

                Console.Write(i3[i] + " ");
            }
        }
    }
}
