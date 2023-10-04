using System;
using System.Globalization;

namespace Exbeecrowd {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + SalarioBruto * (porcentagem / 100);
        }

        public override string ToString() {
            return Nome
            + ", $ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

  class ExBee {
    static void Main(string[] args) {
        
        Funcionario func = new Funcionario();

        Console.Write("Nome: ");
        func.Nome = Console.ReadLine();
        Console.Write("Salário bruto: ");
        func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Funcionário: " + func);

        Console.WriteLine();
        Console.Write("Digite a porcentagem para aumentar o salário: ");
        double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        func.AumentarSalario(aumento);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + func); 
    }   
  }
}  
