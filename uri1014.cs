using System; 

class URI {

    static void Main(string[] args) { 

    int X = int.Parse(Console.ReadLine());
    double Y = double.Parse(Console.ReadLine());

    double consum = X/Y;

    Console.WriteLine(consum.ToString("F3") + " km/l");

    }

}
