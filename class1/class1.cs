using System;
using System.Globalization;

namespace Exbeecrowd {
  class Funcionario {
    public string Nome;
    public double Salario;
  }
  class ExBee {
    static void Main(string[] args) {

      Funcionario f1 = new Funcionario();
      Funcionario f2 = new Funcionario();

      System.Console.WriteLine("Dados do primeiro funcionário");
      System.Console.Write("Nome: ");
      f1.Nome = Console.ReadLine();
      System.Console.Write("Salário: ");
      f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      System.Console.WriteLine("Dados do segundo funcionário");
      System.Console.Write("Nome: ");
      f2.Nome = Console.ReadLine();
      System.Console.Write("Salário: ");
      f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double media = (f1.Salario + f2.Salario) / 2;
      System.Console.WriteLine("Salário Médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
