using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

      double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double media = (A * 3.5 + B * 7.5)/(3.5 + 7.5);

      Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

    }

}
