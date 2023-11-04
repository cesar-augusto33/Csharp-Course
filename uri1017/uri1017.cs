using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

      double time = double.Parse(Console.ReadLine());
      double vel = double.Parse(Console.ReadLine());

      double dist = vel*time;
      double consum = dist/12;

      Console.WriteLine(consum.ToString("F3", CultureInfo.InvariantCulture));
    }
}
