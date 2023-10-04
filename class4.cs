using System;
using System.Globalization;

namespace Exbeecrowd {
    class ConversorDeMoeda {
        public static double Cotacao;
        public static double Valor;

        public static double Iof = 6.0 / 100;
        public static double Conversor () {
            double total = Cotacao * Valor;
            return total + total * Iof;
        }
    }
  class ExBee {
    static void Main(string[] args) {
        
        Console.Write("Qual é a cotação do dólar? ");
        ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? ");
        ConversorDeMoeda.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Conversor().ToString("F2", CultureInfo.InvariantCulture)); 
    }   
  }
}  
