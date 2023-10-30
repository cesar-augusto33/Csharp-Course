using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

      double A, B, C, tria, circ, trap, quad, ret ;
      string[] values = Console.ReadLine().Split(' ');
      A = double.Parse(values[0], CultureInfo.InvariantCulture);
      B = double.Parse(values[1], CultureInfo.InvariantCulture);
      C = double.Parse(values[2], CultureInfo.InvariantCulture); 

      tria = (A*C)/2;
      circ = 3.14159*Math.Pow(C, 2);
      trap = ((A+B)*C)/2;
      quad = Math.Pow(B ,2);
      ret = A*B;

      Console.WriteLine("TRIANGULO: " + tria.ToString("F3"), CultureInfo.InvariantCulture);
      Console.WriteLine("CIRCULO: " + circ.ToString("F3"), CultureInfo.InvariantCulture);
      Console.WriteLine("TRAPEZIO: " + trap.ToString("F3"), CultureInfo.InvariantCulture);
      Console.WriteLine("QUADRADO: " + quad.ToString("F3"), CultureInfo.InvariantCulture);
      Console.WriteLine("RETANGULO: " + ret.ToString("F3"), CultureInfo.InvariantCulture);

    }

}
