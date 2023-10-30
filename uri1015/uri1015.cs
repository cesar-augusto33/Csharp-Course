using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

      string[] values = Console.ReadLine().Split(' ');
      double x1 = double.Parse(values[0]);
      double y1 = double.Parse(values[1]);

      values = Console.ReadLine().Split(' ');
      double x2 = double.Parse(values[0]);
      double y2 = double.Parse(values[1]);
      
      double delta = Math.Pow((x2 - x1), 2) + Math.Pow((y2-y1), 2);
      double dist = Math.Sqrt(delta);

      Console.WriteLine(dist.ToString("F4", CultureInfo.InvariantCulture));

    }

}
