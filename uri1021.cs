using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

      double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      int rest = (int) (N*100 + 0.5);

      Console.WriteLine("NOTAS:");

      int nota = 100;
      int quantNota = rest / (nota * 100);
      Console.WriteLine(quantNota + " nota(s) de R$ 100.00");
      rest = rest % (nota * 100);

      nota = 50;
      quantNota = rest / (nota * 100);
      Console.WriteLine(quantNota + " nota(s) de R$ 50.00");
      rest = rest % (nota * 100);

      nota = 20;
      quantNota = rest / (nota * 100);
      Console.WriteLine(quantNota + " nota(s) de R$ 20.00");
      rest = rest % (nota * 100);

      nota = 10;
      quantNota = rest / (nota * 100);
      Console.WriteLine(quantNota + " nota(s) de R$ 10.00");
      rest = rest % (nota * 100);

      nota = 5;
      quantNota = rest / (nota * 100);
      Console.WriteLine(quantNota + " nota(s) de R$ 5.00");
      rest = rest % (nota * 100);

      nota = 2;
      quantNota = rest / (nota * 100);
      Console.WriteLine(quantNota + " nota(s) de R$ 2.00");
      rest = rest % (nota * 100);

      Console.WriteLine("MOEDAS:");

      nota = 100;
      quantNota = rest / nota;
      Console.WriteLine(quantNota + " moeda(s) de R$ 1.00");
      rest = rest % nota;

      nota = 50;
      quantNota = rest / nota;
      Console.WriteLine(quantNota + " moeda(s) de R$ 0.50");
      rest = rest % nota;

      nota = 25;
      quantNota = rest / nota;
      Console.WriteLine(quantNota + " moeda(s) de R$ 0.25");
      rest = rest % nota;

      nota = 10;
      quantNota = rest / nota;
      Console.WriteLine(quantNota + " moeda(s) de R$ 0.10");
      rest = rest % nota;

      nota = 5;
      quantNota = rest / nota;
      Console.WriteLine(quantNota + " moeda(s) de R$ 0.05");
      rest = rest % nota; 

      Console.WriteLine(rest + " moeda(s) de R$ 0.01");
    }
}
