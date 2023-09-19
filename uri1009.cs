using System; 

class URI {

    static void Main(string[] args) { 

      string name = (Console.ReadLine());
      double salaryFix = double.Parse(Console.ReadLine());
      double totalSales = double.Parse(Console.ReadLine());

      double total = salaryFix + totalSales*0.15;

      Console.WriteLine("TOTAL = R$ " + total.ToString("F2")); 

    }

}
