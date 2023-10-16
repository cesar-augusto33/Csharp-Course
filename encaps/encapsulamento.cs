using System;
using System.Globalization;

namespace Exbeecrowd {
  class Conta {
    public int Numero { get; private set; }
    public string Nome { get; set; }
    public double Saldo { get; private set; }
    public Conta (int numero, string nome) {
      Numero = numero;
      Nome = nome;
    }

    public Conta (int numero, string nome, double saldoInicial) : this(numero, nome) {
      ValorDeposito(saldoInicial);
    }
 
    public void ValorDeposito(double valor) {
      Saldo += valor;
    }

    public void ValorSaque(double valor) {
      Saldo -= valor + 5.0;
    }

    //ToString
    public override string ToString() {
      return "Conta "
      + Numero
      + ", Titular: "
      + Nome
      + ", Saldo: $ "
      + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }
  }
  class ExBee {
    static void Main(string[] args) {

      Conta conta;

      System.Console.Write("Entre o número da conta: ");
      int numero = int.Parse(Console.ReadLine());
      System.Console.Write("Entre o titular da conta: ");
      string nome = Console.ReadLine();
      System.Console.Write("Haverá depósito inicial (s/n)? ");
      char verificValor = char.Parse(Console.ReadLine());

      if (verificValor == 's') {
        System.Console.Write("Entre o valor de depósito inicial: ");
        double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta = new Conta(numero, nome, valorInicial);
      }
      else {
        conta = new Conta(numero, nome);
      }
      
      System.Console.WriteLine();
      System.Console.WriteLine("Dados da conta: ");
      System.Console.WriteLine(conta);

      System.Console.WriteLine();
      System.Console.Write("Entre um valor para depósito: ");
      double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      conta.ValorDeposito(valorDeposito);
      System.Console.WriteLine("Dados da conta atualizados:");
      System.Console.WriteLine(conta);

      System.Console.WriteLine();
      System.Console.Write("Entre um valor para saque: ");
      double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      conta.ValorSaque(valorSaque);
      System.Console.WriteLine("Dados da conta atualizados:");
      System.Console.WriteLine(conta);
    }
  }
}  
