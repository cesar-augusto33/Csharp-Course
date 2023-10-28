using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

      double R = double.Parse(Console.ReadLine());
      double pi = 3.14159;

      double vol = (4.0/3) * pi * Math.Pow(R, 3);

      Console.WriteLine("VOLUME = " + vol.ToString("F3", CultureInfo.InvariantCulture)); 

    }

}
