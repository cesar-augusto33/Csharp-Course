using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

      double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double media = (A * 2 + B * 3 + C * 5)/(2 + 3 + 5);

      Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

    }

}
