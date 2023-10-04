using System;
using System.Globalization;

namespace Exbeecrowd {
    class Produto {
        
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdcionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        //ToString - converte o objeto para string
        public override string ToString() {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
  class ExBee {
    static void Main(string[] args) {

        Produto p = new Produto();

        Console.WriteLine("Entre os dados do produto: ");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser adcionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdcionarProdutos(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p); 

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qte);      

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p); 
    }
  }
}  
