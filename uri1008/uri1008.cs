using System; 

class URI {

    static void Main(string[] args) { 

      int numberEmploy = int.Parse(Console.ReadLine());
      int hourWork = int.Parse(Console.ReadLine());
      double valorHour = double.Parse(Console.ReadLine());

      double salary = hourWork*valorHour;

      Console.WriteLine("NUMBER = " + numberEmploy);
      Console.WriteLine("SALARY = U$ " + salary.ToString("F2"));

    }

}
